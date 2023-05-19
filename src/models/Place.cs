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

        public static void store(Place place)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.Places.Add(place);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}