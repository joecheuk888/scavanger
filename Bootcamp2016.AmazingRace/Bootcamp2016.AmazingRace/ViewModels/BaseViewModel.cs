using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    public class BaseViewModel : Screen
    {

        private readonly INavigationService _navigationService;
        private readonly IAuthenticationService _authService;
        private readonly IDataService _dataService;

        public BaseViewModel(INavigationService navigationService, IAuthenticationService authService, IDataService dataService)
        {
            this._navigationService = navigationService;
            this._authService = authService;
            this._dataService = dataService;
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(field, value))
            {
                field = value;
                NotifyOfPropertyChange(propertyName);
                return true;
            }
            return false;
        }

        protected async override void OnInitialize()
        {
            bool result = await _authService.IsLoggedInAsync();
            if (result)
            {
                await _navigationService.NavigateToViewModelAsync<LoginViewModel>();
            }
            else if (await IsInTeam())
            {
                await _navigationService.NavigateToViewModelAsync<JoinTeamViewModel>();
            }
            else
            {
                await _navigationService.NavigateToViewModelAsync<LeaderViewModel>();
            }
        }

        private async Task<bool> IsInTeam()
        {
            Profile pro = await _dataService.GetProfileAsync();
            foreach (Team t in pro.teams)
            {
                if (t.Equals(pro.id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
