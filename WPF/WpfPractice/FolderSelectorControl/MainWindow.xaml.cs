using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        }

        public static readonly DependencyProperty CurrentPathProperty = DependencyProperty.Register("CurrentPath", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));

        public string CurrentPath
        {
            get { return (string)GetValue(CurrentPathProperty); }
            set { SetValue(CurrentPathProperty, value); }
        }

        public event EventHandler<string> OnOpenClicked;

        private bool _ignoreSelectionChanged;

        //method to initially load the logical drives (c:, d:) into the tree view (DriveTreeView)
        private void LoadDrives()
        {
            Debug.WriteLine("LoadDrives method called.");
            var drives = Directory.GetLogicalDrives();
            var rootDirectories = new ObservableCollection<DirectoryItem>();

            foreach (var drive in drives)
            {
                var item = new DirectoryItem { Name = drive, Path = drive };
                item.SubDirectories.Add(new DirectoryItem { Name = "Loading...", Path = string.Empty });
                rootDirectories.Add(item);
            }

            DriveTreeView.ItemsSource = rootDirectories;
        }

        private void DriveTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DriveTreeView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"DriveTreeView_SelectedItemChanged: {selectedDirectory.Path}");
                CurrentPath = selectedDirectory.Path;
                LoadFolders(CurrentPath);
            }
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

        private void FolderListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"FolderListView_MouseDoubleClick: {selectedDirectory.Path}");
                CurrentPath = selectedDirectory.Path;
                _ignoreSelectionChanged = true;
                LoadFolders(CurrentPath);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"BackButton_Click: CurrentPath before back is {CurrentPath}");
            if (!string.IsNullOrEmpty(CurrentPath))
            {
                var parentDirectory = Directory.GetParent(CurrentPath);
                if (parentDirectory != null)
                {
                    CurrentPath = parentDirectory.FullName;
                    LoadFolders(CurrentPath);
                }
            }
            Debug.WriteLine($"BackButton_Click: CurrentPath after back is {CurrentPath}");
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Selected Path: {CurrentPath}");
            OnOpenClicked?.Invoke(this, CurrentPath);
        }

        private void GoButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"GoButtonClick: CurrentPath is {CurrentPath}");
            if (Directory.Exists(CurrentPath))
            {
                LoadFolders(CurrentPath);
                UpdateTreeView(CurrentPath);
            }
            else
            {
                MessageBox.Show("The path you entered is not valid. Please enter a valid path.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        private void FolderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_ignoreSelectionChanged)
            {
                _ignoreSelectionChanged = false;
                return;
            }

            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                Debug.WriteLine($"FolderListView_SelectionChanged: {selectedDirectory.Path}");
                CurrentPath = selectedDirectory.Path;
            }
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
    }
    public class DirectoryItem : INotifyPropertyChanged
    {
        private string _name;
        private string _path;
        private ObservableCollection<DirectoryItem> _subDirectories;

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
}
