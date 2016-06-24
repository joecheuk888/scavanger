using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    public class JoinTeamViewModel : BaseScreen
    {
        private readonly IAuthenticationService _authService;
        private readonly INavigationService _navigationService;
        private readonly IMobileServiceClient _mobileServiceClient;

        public JoinTeamViewModel(IMobileServiceClient client, IAuthenticationService authService, INavigationService navService)
        {
            this._authService = authService;
            this._navigationService = navService;
            this._mobileServiceClient = client;
        }


        protected async void OnButtonClicked(object sender, EventArgs args)
        {
            //this.TeamCodeEntry;
        }
    }
}
