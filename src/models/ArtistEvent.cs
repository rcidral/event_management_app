using Data;

namespace Models
{
    public class ArtistEvent
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int EventId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Event Event { get; set; }

        public ArtistEvent(int artistId, int eventId)
        {
            ArtistId = artistId;
            EventId = eventId;
        }

        public static void store(ArtistEvent artistEvent)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.ArtistEvents.Add(artistEvent);
                    context.SaveChanges();
                }
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
                using (Context context = new Context())
                {
                    ArtistEvent artistEvent_ = context.ArtistEvents.Find(id);
                    artistEvent_.ArtistId = artistEvent.ArtistId;
                    artistEvent_.EventId = artistEvent.EventId;
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
                    ArtistEvent artistEvent = context.ArtistEvents.Find(id);
                    context.ArtistEvents.Remove(artistEvent);
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