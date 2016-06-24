using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Bootcamp2016.AmazingRace.ViewModels;
using Xamarin.Forms;
using Bootcamp2016.AmazingRace.Services;
using Bootcamp2016.AmazingRace.Views;
using Microsoft.WindowsAzure.MobileServices;
using Bootcamp2016.AmazingRace.Services.Imp;

namespace Bootcamp2016.AmazingRace
{
    public class App : FormsApplication
    {
        //DEV
        private static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        private static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        ////PROD
        //public static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        //public static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            MobileServiceClient client = new MobileServiceClient(MobileServicesUri, MobileServicesAppKey);

        container
                .PerRequest<DetailViewModel>()
<<<<<<< HEAD
=======
                .PerRequest<TabbedView>()
                .PerRequest<LeaderViewModel>()
                .PerRequest<CluesViewModel>()
                .PerRequest<DetailViewModel>()
                .PerRequest<MapViewModel>()
<<<<<<< HEAD
                .PerRequest<TeamViewModel>()
>>>>>>> 95551d7... j3
=======
                .PerRequest<LoginViewModel>()
>>>>>>> 3476c60... Login view shows
                ;

            container.Singleton<ISettingsService, SettingsService>();
            container.Instance<IMobileServiceClient>(client);
            container.Singleton<IAuthenticationService, AuthenticationService>();
            container.Singleton<IDataService, DataService>();

            DisplayRootView<TeamView>();
            //DisplayRootView<TabbedView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
