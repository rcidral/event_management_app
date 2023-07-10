using Data;

namespace Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist(string name)
        {
            Name = name;
        }
        public static void store(Artist artist)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.Artists.Add(artist);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static List<Artist> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Artists.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static Artist show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Artists.Find(id);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static void update(int id, Artist artist)
        {
            try
            {
                using (Context context = new Context())
                {
                    Artist oldArtist = context.Artists.Find(id);
                    oldArtist.Name = artist.Name;
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
                    Artist artist = context.Artists.Find(id);
                    context.Artists.Remove(artist);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Artist getByName(string name)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Artists.Where(artist => artist.Name == name).FirstOrDefault();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        
    }
}