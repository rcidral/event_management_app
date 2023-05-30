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

        public static List<Event> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Events.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Event show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Events.Find(id);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, Event event_, int artistId, int sponsorId, Values values)
        {
            try
            {
                using (Context context = new Context())
                {
                    Event eventOld_ = context.Events.Find(id);
                    eventOld_.Date = event_.Date;
                    eventOld_.Description = event_.Description;
                    eventOld_.UserId = event_.UserId;
                    eventOld_.PlaceId = event_.PlaceId;
                    eventOld_.TypeId = event_.TypeId;

                    context.SaveChanges();
                    ArtistEvent.update(id, new ArtistEvent(artistId, eventOld_.Id));
                    Values.update(id, new Values(values.Date, values.Value, sponsorId, eventOld_.Id));
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
                    Event event_ = context.Events.Find(id);
                    context.Events.Remove(event_);
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