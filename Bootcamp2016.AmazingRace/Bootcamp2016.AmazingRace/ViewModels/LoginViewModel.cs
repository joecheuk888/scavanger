

using Bootcamp2016.AmazingRace.Services;
using Caliburn.Micro.Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : BaseScreen
    {
        private readonly IAuthenticationService _authService;
        private readonly INavigationService _navigationService;
        private readonly IMobileServiceClient _mobileServiceClient;

        public LoginViewModel(IMobileServiceClient client, IAuthenticationService authService, INavigationService navService)
        {
            this._authService = authService;
            this._navigationService = navService;
            this._mobileServiceClient = client;
        }

        protected override void OnInitialize()
        {

        }

        protected override void OnActivate()
        {
            
        }

        protected async void OnButtonClicked(object sender, EventArgs args)
        {
            bool result = await _authService.LoginAsync();
            if (result)
            {
                await _navigationService.GoBackAsync();
            } else
            {

            }
        }
    }
}
