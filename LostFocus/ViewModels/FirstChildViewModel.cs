using LostFocus.BaseClasses;
using LostFocus.RelayCommands;
using LostFocus.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LostFocus.ViewModels
{
    public class FirstChildViewModel : ViewModelBase, IFirstChildViewModel
    {
        public ActionRelayMethod PumpControlCommand { get; set; }

        private readonly NavigationStore _navigationStore;
        public FirstChildViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            PumpControlCommand = new ActionRelayMethod(p => EnterButton());
            //Parameterless constructor
        }

        public void EnterButton()
        {
            _navigationStore.CurrentViewModel = new SecondChildViewModel(_navigationStore);
        }
    }
}
