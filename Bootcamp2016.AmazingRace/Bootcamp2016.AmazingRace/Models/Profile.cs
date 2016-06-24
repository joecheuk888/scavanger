using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Profile model object
    /// </summary>
    public class Profile
    {
        public string id { get; set; }
        public List<Team> teams { get; set; }

    }

}