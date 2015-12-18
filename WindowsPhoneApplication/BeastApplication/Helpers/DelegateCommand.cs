using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeastApplication.Helpers
{
    public class DelegateCommand<T> : ICommand
    {
        private Func<T, bool> canExecute;
        private Action<T> execute;

        public DelegateCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null)
            {
                return true;
            }
            return this.canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            this.execute((T)parameter);
        }
    }
}
