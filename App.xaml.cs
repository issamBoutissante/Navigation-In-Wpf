using Naviagtion_On_Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Naviagtion_On_Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModel = new FirstWindowViewModel(_navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
