using FinancialTrader.WPF.Commands;
using FinancialTrader.WPF.Models;
using FinancialTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinancialTrader.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel 
        {
           get 
           {
                return _currentViewModel;
           }
           set
           {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
           }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
