
using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides the details for a specific clue
    /// </summary>
    public class TeamViewModel : BaseScreen
    {
        IMobileServiceClient client;
        IDataService dataService;
        string teamCode;

        public TeamViewModel(IMobileServiceClient client, IDataService ds) {
            this.client = client;
            this.dataService = ds;

            JoinCommand = new Command(JoinTeam);
            
        }


        public string Name { get {
                return client.CurrentUser.UserId;
            }}

        public string JoinCode {
        set {
                SetField(ref this.teamCode, value);
            }
        }

        public Command JoinCommand { get; set; }

        private async void JoinTeam()
        {
            Team team = await this.dataService.JoinTeamAsync(teamCode);
        }
    }
}
