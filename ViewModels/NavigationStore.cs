using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviagtion_On_Wpf.ViewModels
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        public ViewModelBase CurrentViewModel { get; set; }
        public void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
