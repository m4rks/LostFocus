using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using LostFocus.Interfaces;

namespace LostFocus.RelayCommands
{
    public class NavigateCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
