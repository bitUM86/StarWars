using System.Collections.Generic;

namespace StarWarsInfo.Models
{
    public class Species
    {
        private string name;
        private string classification;
        private string designation;
        private string average_height;
        private string average_lifespan;
        private string eye_colors;
        private string hair_colors;
        private string skin_colors;
        private string language;
        private string homeworld;
        private List<string> people;
        private List<string> films;
        private string url;
        private string created;
        private string edited;


        public string Name { get => name; set => name = value; }
        public string Classification { get => classification; set => classification = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Average_height { get => average_height; set => average_height = value; }
        public string Average_lifespan { get => average_lifespan; set => average_lifespan = value; }
        public string Eye_colors { get => eye_colors; set => eye_colors = value; }
        public string Hair_colors { get => hair_colors; set => hair_colors = value; }
        public string Language { get => language; set => language = value; }
        public string Skin_colors { get => skin_colors; set => skin_colors = value; }
        public string Homeworld { get => homeworld; set => homeworld = value; }
        public List<string> People { get => people; set => people = value; }
        public string Url { get => url; set => url = value; }
        public List<string> Films { get => films; set => films = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
    }
}
