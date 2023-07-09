using Data;

namespace Models
{
    public class Values
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public double Value { get; set; }
        public int SponsorId { get; set; }
        public int EventId { get; set; }
        public virtual Sponsor Sponsor { get; set; }
        public virtual Event Event { get; set; }

        public Values(DateOnly date, double value, int sponsorId, int eventId)
        {
            Date = date;
            Value = value;
            SponsorId = sponsorId;
            EventId = eventId;
        }

        public static void store(Values values)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.ValuesEvent.Add(values);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static List<Values> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.ValuesEvent.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Values show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.ValuesEvent.Find(id);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }



        public static void update(int id, Values values)
        {
            try
            {
                using (Context context = new Context())
                {
                    Values values_ = context.ValuesEvent.Find(id);
                    values_.Date = values.Date;
                    values_.Value = values.Value;
                    values_.SponsorId = values.SponsorId;
                    values_.EventId = values.EventId;
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Values showByEventId(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.ValuesEvent.Where(x => x.EventId == id).FirstOrDefault();
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
                    Values values = context.ValuesEvent.Find(id);
                    context.ValuesEvent.Remove(values);
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