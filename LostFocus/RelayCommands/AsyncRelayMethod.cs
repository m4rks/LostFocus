using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LostFocus.RelayCommands
{
    public class AsyncRelayMethod : ICommand
    {
        private readonly Func<Task> _func;

        public AsyncRelayMethod(Func<Task> func)
        {
            _func = func;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            await _func();
        }

        public event EventHandler CanExecuteChanged;
    }
}
