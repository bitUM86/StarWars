using System;
using System.Collections.Generic;

namespace StarWarsInfo.Models
{
    public class Film
    {
        private string title;
        private int episode_id;
        private string opening_crawl;
        private string director;
        private string producer;
        private DateTime release_date;
        private List<string> species;
        private List<string> starships;
        private List<string> vehicles;
        private List<string> characters;
        private List<string> planets;
        private string url;
        private string created;
        private string edited;


        public string Title { get => title; set => title = value; }
        public int Episode_id { get => episode_id; set => episode_id = value; }
        public string Opening_crawl { get => opening_crawl; set => opening_crawl = value; }
        public string Director { get => director; set => director = value; }
        public string Producer { get => producer; set => producer = value; }
        public DateTime Release_date { get => release_date; set => release_date = value; }
        public List<string> Species { get => species; set => species = value; }
        public List<string> Starships { get => starships; set => starships = value; }
        public List<string> Vehicles { get => vehicles; set => vehicles = value; }
        public List<string> Characters { get => characters; set => characters = value; }
        public List<string> Planets { get => planets; set => planets = value; }
        public string Url { get => url; set => url = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
    }
}
