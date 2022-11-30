using System.Collections.Generic;

namespace starWarsInfo.Models
{
    public class Planet
    {

        private string name;
        private string rotation_period;
        private string orbital_period;
        private string diameter;
        private string climate;
        private string gravity;
        private string terrain;
        private string surface_water;
        private string population;
        private List<string> residents;
        private List<string> films;
        private string edited;
        private string created;
        private string url;


        public string Name { get => name; set => name = value; }
        public string Diameter { get => diameter; set => diameter = value; }
        public string Rotation_period { get => rotation_period; set => rotation_period = value; }
        public string Orbital_period { get => orbital_period; set => orbital_period = value; }
        public string Gravity { get => gravity; set => gravity = value; }
        public string Population { get => population; set => population = value; }
        public string Climate { get => climate; set => climate = value; }
        public string Terrain { get => terrain; set => terrain = value; }
        public string Surface_water { get => surface_water; set => surface_water = value; }
        public List<string> Residents { get => residents; set => residents = value; }
        public List<string> Films { get => films; set => films = value; }
        public string Url { get => url; set => url = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
    }
}
