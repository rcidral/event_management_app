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

        public static void store(Event event_, string artistId, string sponsorId, double values)
        {
            try
            {
                using (Context context = new Context())
                {
                    Artist artist = Artist.getByName(artistId);
                    if (artist == null)
                    {
                        throw new System.Exception("Artist not found");
                    }
                    Sponsor sponsor = Sponsor.getByName(sponsorId);
                    if (sponsor == null)
                    {
                        throw new System.Exception("Sponsor not found");
                    }
                    context.Events.Add(event_);
                    context.SaveChanges();
                    Models.Event eventCreated = Controllers.EventControllers.getByDescription(event_.Description);
                    ArtistEvent.store(new ArtistEvent(eventCreated.Id, artist.Id));
                    Values.store(new Values(event_.Date, values, sponsor.Id, eventCreated.Id));
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


        public static void update(int id, DateOnly date, string description, string user, string place, string type, string artistId, string sponsorId, Double values)
        {
            try
            {
                using (Context context = new Context())
                {
                    Event eventOld_ = context.Events.Find(id);
                    eventOld_.Date = date;
                    eventOld_.Description = description;
                    eventOld_.UserId = Int32.Parse(user);
                    eventOld_.PlaceId = Int32.Parse(place);
                    eventOld_.TypeId = Int32.Parse(type);

                    context.SaveChanges();

                    Artist artist = Artist.getByName(artistId);
                    if (artist == null)
                    {
                        throw new System.Exception("Artist not found");
                    }
                    Sponsor sponsor = Sponsor.getByName(sponsorId);
                    if (sponsor == null)
                    {
                        throw new System.Exception("Sponsor not found");
                    }

                    ArtistEvent.update(id, new ArtistEvent(artist.Id, eventOld_.Id));
                    Values.update(id, new Values(date, values, sponsor.Id, eventOld_.Id));
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
                    context.ArtistEvents.RemoveRange(context.ArtistEvents.Where(artistEvent => artistEvent.EventId == id));
                    context.ValuesEvent.RemoveRange(context.ValuesEvent.Where(valuesEvent => valuesEvent.EventId == id));
                    context.Events.Remove(event_);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Models.Event getByDescription(string description)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Events.Where(event_ => event_.Description == description).FirstOrDefault();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}