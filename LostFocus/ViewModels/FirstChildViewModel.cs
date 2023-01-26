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
        #region Fields
        private readonly NavigationStore _navigationStore;
        #endregion
        #region Property
        public ActionRelayMethod PumpControlCommand { get; set; }
        public ActionRelayMethod StartAnimatedGifCommand { get; set; }

        private string _selectedImage;

        public string SelectedImage
        {
            get { return _selectedImage; }
            set { _selectedImage = value;
                OnPropertyChanged("SelectedImage");
            }
        }

        #endregion

        public FirstChildViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            PumpControlCommand = new ActionRelayMethod(p => EnterButton());
            StartAnimatedGifCommand = new ActionRelayMethod(p => StartAnimatedGif());
            
            //Parameterless constructor
        }

        private void StartAnimatedGif()
        {
            SelectedImage = @"../Images/working.gif";
        }

        public void EnterButton()
        {
            _navigationStore.CurrentViewModel = new SecondChildViewModel(_navigationStore);
        }
    }
}
