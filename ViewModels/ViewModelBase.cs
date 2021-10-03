using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviagtion_On_Wpf.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperyChanged(string proprtyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proprtyName));
        }
    }
}
