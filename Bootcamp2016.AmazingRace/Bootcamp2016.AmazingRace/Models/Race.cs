using System;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Race model object
    /// </summary>
    public class Race
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool enabled { get; set; }
        public List<Team> teams { get; set; }
    }
}