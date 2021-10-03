using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Naviagtion_On_Wpf.Commands
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public abstract void Execute(object parameter);
        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this,new EventArgs());
        }
    }
}
