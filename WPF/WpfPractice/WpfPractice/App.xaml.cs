using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if(e.Args.Length > 0)
            {
                MessageBox.Show(e.Args[0]);
            }
        }

        private void Application_Startup_1(object sender, StartupEventArgs e)
        {
            new MainWindow();
        }
    }
}
