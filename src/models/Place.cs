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

        public static List<Place> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Places.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static List<Place> show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Places.Where(place => place.Id == id).ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, Place place)
        {
            try
            {
                using (Context context = new Context())
                {
                    Place oldPlace = context.Places.Where(place => place.Id == id).FirstOrDefault();
                    oldPlace.Name = place.Name;
                    oldPlace.Address = place.Address;
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    Place place = context.Places.Where(place => place.Id == id).FirstOrDefault();
                    context.Places.Remove(place);
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