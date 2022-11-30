using Microsoft.AspNetCore.WebUtilities;

namespace StarWarsInfo.Models
{
    public class Root
    {
        private string films;
        private string people;
        private string planets;
        private string species;
        private string starships;
        private string vehicles;
        public string Films { get => films; set => films = value; }
        public string People { get => people; set => people = value; }
        public string Planets { get => planets; set => planets = value; }
        public string Species { get => species; set => species = value; }
        public string Starships { get => starships; set => starships = value; }
        public string Vehicles { get => vehicles; set => vehicles = value; }
    }
}
