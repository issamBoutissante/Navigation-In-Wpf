using Naviagtion_On_Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviagtion_On_Wpf.Commands
{
    public class NavigateCommand : CommandBase
    {
        NavigationStore _navigationStore;
        ViewModelBase _nextViewModel;
        public NavigateCommand(NavigationStore navigationStore,ViewModelBase nextViewModel)
        {
            _nextViewModel = nextViewModel;
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _nextViewModel;
            _navigationStore.OnCurrentViewModelChanged();
        }
    }
}
