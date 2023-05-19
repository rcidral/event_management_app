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
        public virtual User User { get; set; }
        public virtual Place Place { get; set; }

        public Event(DateOnly date, string description, int userId, int placeId)
        {
            Date = date;
            Description = description;
            UserId = userId;
            PlaceId = placeId;
        }

        

    }
}