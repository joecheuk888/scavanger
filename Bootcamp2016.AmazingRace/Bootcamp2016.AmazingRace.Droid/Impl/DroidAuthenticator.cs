using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bootcamp2016.AmazingRace.Services;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.Droid.Impl
{
    public class DroidAuthenticator : IPlatformAuthenticator
    {
        private readonly IMobileServiceClient _client;
        public DroidAuthenticator(IMobileServiceClient client)
        {
            this._client = client;
        }
        public async Task<MobileServiceUser> Authenticate(MobileServiceAuthenticationProvider provider)
        {
            return await _client.LoginAsync(Forms.Context, provider);
        }
    }
}