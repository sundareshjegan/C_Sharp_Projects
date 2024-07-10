using System.Windows;

namespace EdgeProcess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InitializeWebView();
        }
        //async void InitializeWebView()
        //{
        //    await webView.EnsureCoreWebView2Async(null);
        //    webView.CoreWebView2.OpenDevToolsWindow();
        //}
    }
}
