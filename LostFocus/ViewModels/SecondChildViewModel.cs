using LostFocus.BaseClasses;
using LostFocus.RelayCommands;
using LostFocus.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LostFocus.ViewModels
{
    public class SecondChildViewModel : ViewModelBase, ISecondChildViewModel
    {
        public ActionRelayMethod First_ControlCommand { get; set; }

        private readonly NavigationStore _navigationStore;
        public SecondChildViewModel(NavigationStore navigationStore)
        {
            this._navigationStore = navigationStore;
            //Parameterless Constructor.
            First_ControlCommand = new ActionRelayMethod(p => EnterButton());
        }
        public void EnterButton()
        {
            _navigationStore.CurrentViewModel = new FirstChildViewModel(_navigationStore);
        }
    }
}
