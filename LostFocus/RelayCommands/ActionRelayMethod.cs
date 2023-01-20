using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LostFocus.RelayCommands
{
    public class ActionRelayMethod : ICommand
    {
        private readonly Action<object> _action;

        public ActionRelayMethod(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
