using Models;

namespace Test
{
    public class ArtistTeste
    {
        public static void store()
        {
            try
            {
                Artist artist = new Artist("Teste");
                Artist.store(artist);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

    }
}