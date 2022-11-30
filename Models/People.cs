using System.Collections.Generic;

namespace StarWarsInfo.Models
{
    public class People
    {
        private string name;
        private string birth_year;
        private string eye_color;
        private string gender;
        private string hair_color;
        private string height;
        private string mass;
        private string skin_color;
        private string homeworld;
        private List<string> films;
        private List<string> species;
        private List<string> starships;
        private List<string> vehicles;
        private string url;
        private string created;
        private string edited;

        public string Name { get => name; set => name = value; }
        public string Birth_year { get => birth_year; set => birth_year = value; }
        public string Eye_color { get => eye_color; set => eye_color = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Hair_color { get => hair_color; set => hair_color = value; }
        public string Height { get => height; set => height = value; }
        public string Mass { get => mass; set => mass = value; }
        public string Skin_color { get => skin_color; set => skin_color = value; }
        public string Homeworld { get => homeworld; set => homeworld = value; }
        public List<string> Films { get => films; set => films = value; }
        public List<string> Species { get => species; set => species = value; }
        public List<string> Starships { get => starships; set => starships = value; }
        public List<string> Vehicles { get => vehicles; set => vehicles = value; }
        public string Url { get => url; set => url = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
       
    }
}
