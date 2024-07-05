using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;

namespace FolderSelectorControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadDrives();
            PathSuggestions = new ObservableCollection<string>();
            PathSuggestionsListBox.ItemsSource = PathSuggestions;

            PathTB.GotFocus += PathTB_GotFocus;
            PathTB.LostFocus += PathTB_LostFocus;
            TitleBar.MouseLeftButtonDown += TitleBar_MouseLeftButtonDown;

            DesktopItem.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DownloadsItem.Tag = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            PicturesItem.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DocumentsItem.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            VideosItem.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Downloads");
        }

        public static readonly DependencyProperty CurrentPathProperty = DependencyProperty.Register("CurrentPath", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));

        public string SelectedPath
        {
            get { return (string)GetValue(CurrentPathProperty); }
            set { SetValue(CurrentPathProperty, value); }
        }

        public event EventHandler<string> OnOpenClicked;

        public ObservableCollection<string> PathSuggestions { get; set; }

        private bool _ignoreSelectionChanged, _isTyping;

        #region Title bar and Resize

        private void TitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            const int resizeBorderThickness = 5;
            Point mousePosition = e.GetPosition(this);

            if (mousePosition.X <= resizeBorderThickness && mousePosition.Y <= resizeBorderThickness)
            {
                Cursor = Cursors.SizeNWSE;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.TopLeft);
                }
            }
            else if (mousePosition.X >= this.ActualWidth - resizeBorderThickness && mousePosition.Y <= resizeBorderThickness)
            {
                Cursor = Cursors.SizeNESW;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.TopRight);
                }
            }
            else if (mousePosition.X <= resizeBorderThickness && mousePosition.Y >= this.ActualHeight - resizeBorderThickness)
            {
                Cursor = Cursors.SizeNESW;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.BottomLeft);
                }
            }
            else if (mousePosition.X >= this.ActualWidth - resizeBorderThickness && mousePosition.Y >= this.ActualHeight - resizeBorderThickness)
            {
                Cursor = Cursors.SizeNWSE;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.BottomRight);
                }
            }
            else if (mousePosition.Y <= resizeBorderThickness)
            {
                Cursor = Cursors.SizeNS;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.Top);
                }
            }
            else if (mousePosition.Y >= this.ActualHeight - resizeBorderThickness)
            {
                Cursor = Cursors.SizeNS;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.Bottom);
                }
            }
            else if (mousePosition.X <= resizeBorderThickness)
            {
                Cursor = Cursors.SizeWE;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.Left);
                }
            }
            else if (mousePosition.X >= this.ActualWidth - resizeBorderThickness)
            {
                Cursor = Cursors.SizeWE;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ResizeWindow(ResizeDirection.Right);
                }
            }
            else
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void ResizeWindow(ResizeDirection direction)
        {
            HwndSource hwndSource = (HwndSource)PresentationSource.FromVisual(this);
            if (hwndSource != null)
            {
                SendMessage(hwndSource.Handle, WM_SYSCOMMAND, (IntPtr)(SC_SIZE + direction), IntPtr.Zero);
            }
        }

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_SIZE = 0xF000;

        private enum ResizeDirection
        {
            Left = 1,
            Right = 2,
            Top = 3,
            TopLeft = 4,
            TopRight = 5,
            Bottom = 6,
            BottomLeft = 7,
            BottomRight = 8
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Rest of your existing code

        #endregion

        //method to initially load the logical drives (c:, d:) into the tree view (DriveTreeView)
        private void LoadDrives()
        {
            Debug.WriteLine("LoadDrives method called.");
            var drives = Directory.GetLogicalDrives();
            var rootDirectories = new ObservableCollection<DirectoryItem>();

            foreach (var drive in drives)
            {
                var item = new DirectoryItem { Name = drive, Path = drive, IsDrive = true };
                item.SubDirectories.Add(new DirectoryItem { Name = "Loading...", Path = string.Empty });
                rootDirectories.Add(item);
            }

            DriveTreeView.ItemsSource = rootDirectories;
        }

        private void LoadFolders(string path)
        {
            Debug.WriteLine($"LoadFolders method called with path: {path}");
            var folders = new ObservableCollection<DirectoryItem>();
            try
            {
                if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                {
                    var dirs = Directory.GetDirectories(path);
                    foreach (var dir in dirs)
                    {
                        folders.Add(new DirectoryItem { Name = System.IO.Path.GetFileName(dir), Path = dir });
                    }
                }
                else
                {
                    Debug.WriteLine($"Invalid or empty path: {path}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading folders for {path}: {ex.Message}");
            }
            FolderListView.ItemsSource = folders;
        }

        private ObservableCollection<DirectoryItem> GetSubDirectories(string path)
        {
            Debug.WriteLine($"GetSubDirectories method called with path: {path}");
            var directories = new ObservableCollection<DirectoryItem>();

            try
            {
                if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                {
                    var dirs = Directory.GetDirectories(path);
                    foreach (var dir in dirs)
                    {
                        var item = new DirectoryItem { Name = Path.GetFileName(dir), Path = dir };
                        item.SubDirectories.Add(new DirectoryItem { Name = "Loading...", Path = string.Empty });
                        directories.Add(item);
                    }
                }
                else
                {
                    Debug.WriteLine($"Invalid or empty path: {path}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error getting subdirectories for {path}: {ex.Message}");
            }

            return directories;
        }

        private void DriveTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DriveTreeView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"DriveTreeView_SelectedItemChanged: {selectedDirectory.Path}");
                SelectedPath = selectedDirectory.Path;
                LoadFolders(SelectedPath);
            }
        }
        
        private void UpdateTreeView(string path)
        {
            Debug.WriteLine($"UpdateTreeView method called with path: {path}");
            var parts = path.Split(new[] {Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                var root = DriveTreeView.ItemsSource as ObservableCollection<DirectoryItem>;
                var drive = root.FirstOrDefault(d => path.StartsWith(d.Path, StringComparison.OrdinalIgnoreCase));
                if (drive != null)
                {
                    ExpandTreeViewItem(drive, parts, 1);
                }
            }
        }

        private void ExpandTreeViewItem(DirectoryItem currentItem, string[] parts, int index)
        {
            if (index >= parts.Length)
            {
                var treeViewItemFinal = GetTreeViewItemFromObject(DriveTreeView, currentItem);
                if (treeViewItemFinal != null)
                {
                    treeViewItemFinal.IsSelected = true;
                    treeViewItemFinal.BringIntoView();
                }
                return;
            }

            var treeViewItemCurrent = GetTreeViewItemFromObject(DriveTreeView, currentItem);
            if (treeViewItemCurrent != null)
            {
                treeViewItemCurrent.IsExpanded = true;
            }

            var nextItem = currentItem.SubDirectories.FirstOrDefault(d => d.Name.Equals(parts[index], StringComparison.OrdinalIgnoreCase));
            if (nextItem == null)
            {
                nextItem = new DirectoryItem
                {
                    Name = parts[index],
                    Path = Path.Combine(currentItem.Path, parts[index]),
                };
                currentItem.SubDirectories.Add(nextItem);
            }

            ExpandTreeViewItem(nextItem, parts, index + 1);
        }

        private TreeViewItem GetTreeViewItemFromObject(ItemsControl parent, object item)
        {
            TreeViewItem foundTreeViewItem = null;
            for (int i = 0; i < parent.Items.Count; i++)
            {
                var currentTreeViewItem = parent.ItemContainerGenerator.ContainerFromIndex(i) as TreeViewItem;
                if (currentTreeViewItem == null)
                {
                    parent.UpdateLayout();
                    currentTreeViewItem = parent.ItemContainerGenerator.ContainerFromIndex(i) as TreeViewItem;
                }

                if (currentTreeViewItem != null && currentTreeViewItem.DataContext == item)
                {
                    foundTreeViewItem = currentTreeViewItem;
                    break;
                }

                if (currentTreeViewItem != null)
                {
                    foundTreeViewItem = GetTreeViewItemFromObject(currentTreeViewItem, item);
                    if (foundTreeViewItem != null)
                    {
                        break;
                    }
                }
            }
            return foundTreeViewItem;
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is TreeViewItem item && item.Header is DirectoryItem directoryItem)
            {
                Debug.WriteLine($"TreeViewItem_Expanded: {directoryItem.Path}");
                if (directoryItem.SubDirectories.Count == 1 && directoryItem.SubDirectories[0].Path == string.Empty)
                {
                    directoryItem.SubDirectories.Clear();

                    try
                    {
                        var subDirs = GetSubDirectories(directoryItem.Path);
                        foreach (var subDir in subDirs)
                        {
                            directoryItem.SubDirectories.Add(subDir);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error expanding tree view item for {directoryItem.Path}: {ex.Message}");
                    }
                }
            }
        }

        private void FolderListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _isTyping = false;

            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"FolderListView_MouseDoubleClick: {selectedDirectory.Path}");
                SelectedPath = selectedDirectory.Path;
                _ignoreSelectionChanged = true;
                LoadFolders(SelectedPath);
            }
        }

        private void FolderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _isTyping = false;

            if (_ignoreSelectionChanged)
            {
                _ignoreSelectionChanged = false;
                return;
            }

            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"FolderListView_SelectionChanged: {selectedDirectory.Path}");
                SelectedPath = selectedDirectory.Path;
            }
        }

        private void PathTB_GotFocus(object sender, RoutedEventArgs e)
        {
            _isTyping = true;
        }

        private void PathTB_LostFocus(object sender, RoutedEventArgs e)
        {
            _isTyping = false;
            PathSuggestionsPopup.IsOpen = false;
        }

        private void PathTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_isTyping) return;

            var input = PathTB.Text;
            if (string.IsNullOrEmpty(input))
            {
                PathSuggestionsPopup.IsOpen = false;
                return;
            }

            var suggestions = GetPathSuggestions(input);
            if (suggestions.Any())
            {
                PathSuggestions.Clear();
                foreach (var suggestion in suggestions)
                {
                    PathSuggestions.Add(suggestion);
                }
                PathSuggestionsPopup.IsOpen = true;
            }
            else
            {
                PathSuggestions.Clear();
                PathSuggestions.Add("No paths found");
                //PathSuggestionsPopup.IsOpen = false;
            }
        }
        
        private IEnumerable<string> GetPathSuggestions(string input)
        {
            var suggestions = new List<string>();
            try
            {
                if (input.Length == 2 && char.IsLetter(input[0]) && input[1] == ':')
                {
                    suggestions.AddRange(Directory.GetLogicalDrives().Where(d => d.StartsWith(input, StringComparison.OrdinalIgnoreCase)));
                }
                else
                {
                    var directoryName = Path.GetDirectoryName(input);
                    if (Directory.Exists(directoryName))
                    {
                        suggestions.AddRange(Directory.GetDirectories(directoryName).Where(d => d.StartsWith(input, StringComparison.OrdinalIgnoreCase)));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error getting path suggestions: {ex.Message}");
            }
            return suggestions;
        }

        private void PathSuggestionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PathSuggestionsListBox.SelectedItem is string selectedPath && PathSuggestionsListBox.SelectedItem.ToString() != "No paths found")
            {
                PathTB.Text = selectedPath;
                PathSuggestionsPopup.IsOpen = false;
            }
        }

        private void GoButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"GoButtonClick: CurrentPath is {SelectedPath}");
            if (Directory.Exists(SelectedPath))
            {
                LoadFolders(SelectedPath);
                UpdateTreeView(SelectedPath);
            }
            else
            {
                MessageBox.Show("The path you entered is not valid. Please enter a valid path.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Warning);
                //MessageBox.Show("You can't open this location using this program. Please try a different location.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"BackButton_Click: CurrentPath before back is {SelectedPath}");
            if (!string.IsNullOrEmpty(SelectedPath))
            {
                var parentDirectory = Directory.GetParent(SelectedPath);
                if (parentDirectory != null)
                {
                    SelectedPath = parentDirectory.FullName;
                    LoadFolders(SelectedPath);
                }
            }
            Debug.WriteLine($"BackButton_Click: CurrentPath after back is {SelectedPath}");
        }

        private void QuickAccessListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (QuickAccessListView.SelectedItem is ListViewItem selectedItem)
            {
                string path = string.Empty;

                // Get the tag value which contains the folder path
                if (selectedItem.Tag is Environment.SpecialFolder specialFolder)
                {
                    path = Environment.GetFolderPath(specialFolder);
                }
                else if (selectedItem.Tag is string customPath)
                {
                    path = customPath;
                }

                if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                {
                    SelectedPath = path;
                    LoadFolders(SelectedPath);
                }
            }
        }

        private void QuickAccessListView_LostFocus(object sender, RoutedEventArgs e)
        {
            QuickAccessListView.SelectedItem = null;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Open Button Clicked: CurrentPath is {SelectedPath}");
            if (Directory.Exists(SelectedPath))
            {
                MessageBox.Show($"Selected Path: {SelectedPath}");
                OnOpenClicked?.Invoke(this, SelectedPath);
            }
            else
            {
                //MessageBox.Show("The path you entered is not valid. Please enter a valid path.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Warning);
                MessageBox.Show("You can't open this location using this program. Please try a different location.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
    public class DirectoryItem : INotifyPropertyChanged
    {
        private string _name;
        private string _path;
        private ObservableCollection<DirectoryItem> _subDirectories;
        private bool _isDrive;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; OnPropertyChanged(nameof(Path)); }
        }

        public ObservableCollection<DirectoryItem> SubDirectories
        {
            get { return _subDirectories; }
            set { _subDirectories = value; OnPropertyChanged(nameof(SubDirectories)); }
        }

        public bool IsDrive
        {
            get { return _isDrive; }
            set { _isDrive = value; OnPropertyChanged(nameof(IsDrive)); }
        }

        public DirectoryItem()
        {
            SubDirectories = new ObservableCollection<DirectoryItem>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class PathToFolderNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string path && !string.IsNullOrEmpty(path))
            {
                return Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar));
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
