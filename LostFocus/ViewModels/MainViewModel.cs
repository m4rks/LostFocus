using LostFocus.BaseClasses;
using LostFocus.RelayCommands;
using LostFocus.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LostFocus.ViewModels
{
    /// <summary>
    /// This MainViewModel acts as an orchestrator, determining which ViewModel is of interest to the user.
    /// To conform to the MVVM design pattern the ViewModels have no knowledge of how the views are implemented, this is handled using data templates in the App.xaml file.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public object CurrentView { get; set; }


        private readonly IFirstChildViewModel _firstChildViewModel;
        private readonly ISecondChildViewModel _secondChildViewModel;
        #region myVar
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        #endregion
        public MainViewModel(IFirstChildViewModel firstChildViewModel, ISecondChildViewModel secondChildViewModel)
        {
            _firstChildViewModel = firstChildViewModel;
            _secondChildViewModel = secondChildViewModel;

            //test code

            Random rnd = new Random();
            CurrentView = (object)firstChildViewModel; // rnd.Next(2) > 0 ? (object)firstChildViewModel : (object)secondChildViewModel;
        }


        public ICommand ActivatedCommand
        {
            get { return new DelegateCommand<object>(Handle); }
        }

        public void Handle(object o)
        {
            //do something...
        }
    }
}
