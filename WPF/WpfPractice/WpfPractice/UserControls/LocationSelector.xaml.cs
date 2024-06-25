using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace WpfPractice.UserControls
{
    /// <summary>
    /// Interaction logic for LocationSelector.xaml
    /// </summary>
    public partial class LocationSelector : UserControl
    {
        public LocationSelector()
        {
            InitializeComponent();
            DataContext = this;

        }
        public event EventHandler<string> SelectionDone;
        private bool dialogShown = false;

       

        public string SelectedFolderPath
        {
            get { return (string)GetValue(SelectedFolderPathProperty); }
            set { SetValue(SelectedFolderPathProperty, value); }
        }

        public static readonly DependencyProperty SelectedFolderPathProperty =
            DependencyProperty.Register("SelectedFolderPath", typeof(string), typeof(LocationSelector), new PropertyMetadata(string.Empty));

        private void BrowseFolderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!dialogShown)
            {
                dialogShown = true;
                var dialog = new OpenFileDialog
                {
                    CheckFileExists = false,
                    CheckPathExists = true,
                    Multiselect = false,
                    Filter = "Folders|.",
                    FileName = "Select Folder"
                };
                if (dialog.ShowDialog() == true)
                {
                    SelectedFolderPath = System.IO.Path.GetDirectoryName(dialog.FileName);
                }
                dialogShown = false;
            }
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            SelectionDone?.Invoke(this,SelectedFolderPath);
        }
    }

}
