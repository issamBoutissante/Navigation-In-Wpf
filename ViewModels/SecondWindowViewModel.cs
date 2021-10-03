using Naviagtion_On_Wpf.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviagtion_On_Wpf.ViewModels
{
    class SecondWindowViewModel :ViewModelBase
    {
        public RelayCommand NavigateToFirstCommand { get; set; }
        void NavigateToFirst()
        {

        }
        public SecondWindowViewModel()
        {
            NavigateToFirstCommand = new RelayCommand(NavigateToFirst);
        }
    }
}
