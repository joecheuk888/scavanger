

using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro.Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of leaders in order for a specific race
    /// </summary>
    public class LeaderViewModel : BaseScreen
    {
        private readonly INavigationService _navigationService;
        public Command NextClueCommand { get; set; }

        public LeaderViewModel( INavigationService navService)
        {
            this._navigationService = navService;
            NextClueCommand = new Command(NextClue);
        }

        private void NextClue()
        {
            _navigationService.NavigateToViewModelAsync<CluesViewModel>();
        }
    }
}
