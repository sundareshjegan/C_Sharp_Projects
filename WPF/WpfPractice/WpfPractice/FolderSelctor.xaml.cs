using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for FolderSelctor.xaml
    /// </summary>
    public partial class FolderSelector : Window
    {
        private string currentPath;
        public FolderSelector()
        {
            InitializeComponent();
        }
        private void LoadDrives()
        {
            var drives = Directory.GetLogicalDrives();
            var rootDirectories = new ObservableCollection<DirectoryItem>();

            foreach (var drive in drives)
            {
                var item = new DirectoryItem { Name = drive, Path = drive };
                item.SubDirectories = GetSubDirectories(item.Path);
                rootDirectories.Add(item);
            }

            DriveTreeView.ItemsSource = rootDirectories;
        }
        private ObservableCollection<DirectoryItem> GetSubDirectories(string path)
        {
            var directories = new ObservableCollection<DirectoryItem>();

            try
            {
                var dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    var item = new DirectoryItem { Name = Path.GetFileName(dir), Path = dir };
                    item.SubDirectories = GetSubDirectories(item.Path);
                    directories.Add(item);
                }
            }
            catch { }

            return directories;
        }
        private void DriveTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DriveTreeView.SelectedItem is DirectoryItem selectedDirectory)
            {
                currentPath = selectedDirectory.Path;
                LoadFolders(currentPath);
            }
        }
        private void LoadFolders(string path)
        {
            var folders = new ObservableCollection<DirectoryItem>();

            try
            {
                var dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    folders.Add(new DirectoryItem { Name = Path.GetFileName(dir), Path = dir });
                }
            }
            catch { }

            FolderListView.ItemsSource = folders;
        }
        private void FolderListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                currentPath = selectedDirectory.Path;
                LoadFolders(currentPath);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentPath))
            {
                var parentDirectory = Directory.GetParent(currentPath);
                if (parentDirectory != null)
                {
                    currentPath = parentDirectory.FullName;
                    LoadFolders(currentPath);
                }
            }
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Selected Path: {currentPath}");
        }

        private void LoadBtnClick(object sender, RoutedEventArgs e)
        {
            LoadDrives();
        }

        private void FolderListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (FolderListView.SelectedItem is DirectoryItem selectedDirectory)
            {
                currentPath = selectedDirectory.Path;
                // Display the current path in the console for debugging purposes.
                Console.WriteLine(currentPath);
            }
        }
    }
    public class DirectoryItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ObservableCollection<DirectoryItem> SubDirectories { get; set; }
    }
}
