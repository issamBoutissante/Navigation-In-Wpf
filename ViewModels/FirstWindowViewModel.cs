using Naviagtion_On_Wpf.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Naviagtion_On_Wpf.ViewModels
{
    class FirstWindowViewModel : ViewModelBase
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set 
            {
                firstName = value;
                OnProperyChanged(nameof(FirstName));
                OnProperyChanged(nameof(FullName));
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnProperyChanged(nameof(LastName));
                OnProperyChanged(nameof(FullName));
            }
        }
        public string FullName => $"{firstName} {lastName}";
        public readonly NavigationStore _navigationStore;
        public NavigateCommand NavigateToSecondCommand => new NavigateCommand(_navigationStore,new SecondWindowViewModel());
        public FirstWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
