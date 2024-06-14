using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
namespace WinformsPractice
{
    public partial class YoutubePlayerControl : UserControl
    {
        private ChromiumWebBrowser browser;

        public YoutubePlayerControl()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            // Create ChromiumWebBrowser instance
            browser = new ChromiumWebBrowser("https://www.youtube.com/watch?v=My_S68DAAPg");

            // Dock the browser to fill the UserControl
            browser.Dock = DockStyle.Fill;

            // Add the browser to the UserControl's Controls collection
            Controls.Add(browser);
        }
    }

}
