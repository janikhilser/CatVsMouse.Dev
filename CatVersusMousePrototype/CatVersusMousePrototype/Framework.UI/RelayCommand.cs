using System;
using System.Windows.Input;

namespace CatVersusMousePrototype.Framework.UI
{
    public class RelayCommand : ICommand
    {
        private readonly Func<object, bool> _func;

        private readonly Action<object> _action; 

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _func = canExecute;
            _action = execute;
        }

        public bool CanExecute(object parameter)
        {
            if (_func == null)
                return true;
            return _func(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged

        {

            // wire the CanExecutedChanged event only if the canExecute func

            // is defined (that improves perf when canExecute is not used)

            add

            {

                if (this._func != null)

                    CommandManager.RequerySuggested += value;

            }

            remove

            {

                if (this._func != null)

                    CommandManager.RequerySuggested -= value;

            }

        }
    }
}