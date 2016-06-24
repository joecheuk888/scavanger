
using Bootcamp2016.AmazingRace.Services;
using Microsoft.WindowsAzure.MobileServices;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides the details for a specific clue
    /// </summary>
    public class TeamViewModel : BaseScreen
    {
        IMobileServiceClient client;
        IDataService dataService;
        string inputboxValue;
        public TeamViewModel(IMobileServiceClient client, IDataService ds) {
            this.client = client;
            this.dataService = ds;

        }


        public string Name { get {
                return client.CurrentUser.UserId;
            }}

        public void JoinTeam() {
            dataService.JoinTeamAsync(this.inputboxValue);
        }

        public string InputTextBox {
        set {
                this.inputboxValue = value;
            }
        }
    }
}
