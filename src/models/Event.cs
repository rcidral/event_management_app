using Data;

namespace Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int PlaceId { get; set; }
        public int TypeId { get; set; }
        public virtual User User { get; set; }
        public virtual Place Place { get; set; }
        public virtual Type Type { get; set; }        

        public Event(DateOnly date, string description, int userId, int placeId, int typeId)
        {
            Date = date;
            Description = description;
            UserId = userId;
            PlaceId = placeId;
            TypeId = typeId;
        }

        public static void store(Event event_, int artistId)
        {
            try
            {
                using (Context context = new Context())
                {
                    Artist artist = context.Artists.Find(artistId);
                    if (artist == null)
                    {
                        throw new System.Exception("Artist not found");
                    }
                    context.Events.Add(event_);
                    context.SaveChanges();
                    ArtistEvent.store(new ArtistEvent(event_.Id, artistId));
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}