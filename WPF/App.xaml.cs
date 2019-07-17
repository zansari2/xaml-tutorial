using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MainWindow wnd = new MainWindow();
            // Do stuff here, e.g. to the window
            if (e.Args.Length == 1)
            {
                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            }
            wnd.Show();
            wnd.Title = "I'm working?";
            // Show the window
            wnd.Show();
        }
    }
}
