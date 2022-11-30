namespace StarWarsInfo.Models
{
    public class Person
    {

        public int Id;
        public string Name;
        public int Age;
        public Person(int _id, string _name, int _age)
        {
            Id= _id;
            Name= _name;    
            Age= _age;
        }

    }
}
