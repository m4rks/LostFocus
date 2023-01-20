using LostFocus.BaseClasses;
using LostFocus.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LostFocus.ViewModels
{
    public class SecondChildViewModel : ViewModelBase, ISecondChildViewModel
    {
        private readonly NavigationStore _navigationStore;
        public SecondChildViewModel(NavigationStore navigationStore)
        {
            this._navigationStore = navigationStore;
            //Parameterless Constructor.
        }
    }
}
