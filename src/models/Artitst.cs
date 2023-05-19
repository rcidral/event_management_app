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
    }
}