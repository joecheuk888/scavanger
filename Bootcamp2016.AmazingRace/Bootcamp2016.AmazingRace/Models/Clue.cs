namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Clue details
    /// </summary>
    public class Clue
    {
        public string id { get; set; }
        public string description { get; set; }
        public int points { get; set; }
        public double lattitude { get; set; }
        public double longtitude { get; set; }
        public int range { get; set; }
    }
}