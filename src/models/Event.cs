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

        public static void store(Event event_, int artistId, int sponsorId, Values values)
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
                    Sponsor sponsor = context.Sponsors.Find(sponsorId);
                    if (sponsor == null)
                    {
                        throw new System.Exception("Sponsor not found");
                    }
                    context.Events.Add(event_);
                    context.SaveChanges();
                    ArtistEvent.store(new ArtistEvent(event_.Id, artistId));
                    Values.store(new Values(values.Date, values.Value, sponsorId, event_.Id));
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}