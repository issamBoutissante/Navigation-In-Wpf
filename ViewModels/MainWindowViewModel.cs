using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviagtion_On_Wpf.ViewModels
{
    public class MainWindowViewModel:ViewModelBase
    {
        public readonly NavigationStore _navigationStore=new NavigationStore();
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += _navigationStore_OnCurrentModeViewChanged;
        }

        private void _navigationStore_OnCurrentModeViewChanged()
        {
            OnProperyChanged(nameof(CurrentViewModel));
        }
    }
}
