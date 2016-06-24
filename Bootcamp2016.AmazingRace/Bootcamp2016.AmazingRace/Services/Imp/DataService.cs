using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp2016.AmazingRace.Models;
using System.Json;
using System.Net;
using System.IO;
using Microsoft.WindowsAzure.MobileServices;

namespace Bootcamp2016.AmazingRace.Services.Imp
{
    class DataService : IDataService
    {
        private IMobileServiceClient client;
        public DataService(IMobileServiceClient client)
        {
            this.client = client;
        }

        public Task<Clue> GetClueAsync(string clueId)
        {
            string url = "http://infusionamazingreace.azure-mobile.net/api/clue/" + clueId;
            return client.InvokeApiAsync<Clue>(url);
        }

        public Task<List<Clue>> GetCluesAsync(string raceId)
        {
            string url = "http://infusionamazingreace.azure-mobile.net/api/" + raceId + "/clues";
            return client.InvokeApiAsync<List<Clue>>(url);
        }

        public Task<string> GetNextClueIdAsync(string teamId, string raceId)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> GetProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Race> GetRaceAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Race>> GetRacesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Team> JoinTeamAsync(string teamCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostClueResponse(string clueId, double lat, double lng, byte[] dataArray)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostLocationUpdate(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterForPushNotifications(string regId)
        {
            throw new NotImplementedException();
        }

        public Task<string> SkipClueAsync(string teamId, string raceId, int skip)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDeviceInfoForPushNotifications(string regId, DeviceRegistration device)
        {
            throw new NotImplementedException();
        }
    }
}
