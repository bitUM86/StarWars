using System.Collections.Generic;

namespace StarWarsInfo.Models
{
    public class Resident
    {
   
        public string Name { get ; set ; }
        public string Birth_year { get ; set ; }
        public string Eye_color { get ; set ; }
        public string Gender { get ; set ; }
        public string Hair_color { get; set ; }
        public string Height { get ; set ; }
        public string Mass { get ; set ; }
        public string Skin_color { get ; set ; }
        public string Homeworld { get ; set ; }
        public List<string> Films { get ; set ; }
        public List<string> Species { get ; set ; }
        public List<string> Starships { get ; set ; }
        public List<string> Vehicles { get ; set ; }
        public string Url { get ; set ; }
        public string Created { get ; set ; }
        public string Edited { get ; set ; }
       
    }
}
