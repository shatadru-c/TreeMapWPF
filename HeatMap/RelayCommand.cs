using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HeatMap
{
    class RelayCommand : ICommand
    {
        private readonly Func<bool> canExecute_;
        private readonly Action action;

        public RelayCommand(Func<bool> canExecute_,Action execute_)
        {
            this.canExecute_ = canExecute_;
            this.action = execute_;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute_();
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
