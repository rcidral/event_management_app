using Models;

namespace Test
{
    public class ArtistEventTest
    {
        public static void store(ArtistEvent artistEvent)
        {
            try
            {
                ArtistEvent artistEvent_ = new ArtistEvent(artistEvent.ArtistId, artistEvent.EventId);
                ArtistEvent.store(artistEvent_);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, ArtistEvent artistEvent)
        {
            try
            {
                ArtistEvent artistEvent_ = new ArtistEvent(artistEvent.ArtistId, artistEvent.EventId);
                ArtistEvent.update(id, artistEvent_);
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
                ArtistEvent.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        
    }
}