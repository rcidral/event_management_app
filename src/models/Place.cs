using Data;

namespace Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address {get; set;}

        public Place(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}