using System.Collections.Generic;

namespace StarWarsInfo.Models
{
    public class Vehicles
    {
        private string name;
        private string model;
        private string vehicle_class;
        private string manufacturer;
        private string cost_in_credits;
        private string length;
        private string crew;
        private string passangers;
        private string max_atmospheric_speed;
        private string cargo_capacity;
        private string consumables;
        private List<string> films;
        private List<string> pilots;
        private string url;
        private string created;
        private string edited;
        public string Cargo_capacity { get => cargo_capacity; set => cargo_capacity = value; }
        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Starship_class { get => vehicle_class; set => vehicle_class = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Cost_in_credits { get => cost_in_credits; set => cost_in_credits = value; }
        public string Length { get => length; set => length = value; }
        public string Crew { get => crew; set => crew = value; }
        public string Passangers { get => passangers; set => passangers = value; }
        public string Max_atmospheric_speed { get => max_atmospheric_speed; set => max_atmospheric_speed = value; }
        public string Consumables { get => consumables; set => consumables = value; }
        public string Url { get => url; set => url = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
        public List<string> Films { get => films; set => films = value; }
        public List<string> Pilots { get => pilots; set => pilots = value; }

    }
}
