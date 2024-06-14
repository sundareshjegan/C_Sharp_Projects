using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace WinformsPractice
{
    public partial class ChromeBrowserControl : UserControl
    {
        private ChromiumWebBrowser browser;
        public ChromeBrowserControl()
        {
            InitializeBrowser();
        }
        private void InitializeBrowser()
        {
            // Create ChromiumWebBrowser instance
            browser = new ChromiumWebBrowser("https://www.google.com");

            // Dock the browser to fill the UserControl
            browser.Dock = DockStyle.Fill;

            // Add the browser to the UserControl's Controls collection
            Controls.Add(browser);
        }
    }
}
