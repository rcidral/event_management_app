using Data;

namespace Models
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sponsor(string name)
        {
            Name = name;
        }
        public static void store(Sponsor sponsor)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.Sponsors.Add(sponsor);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static List<Sponsor> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Sponsors.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static Sponsor show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Sponsors.Find(id);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static void update(int id, Sponsor sponsor)
        {
            try
            {
                using (Context context = new Context())
                {
                    Sponsor oldSponsor = context.Sponsors.Find(id);
                    oldSponsor.Name = sponsor.Name;
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
                    Sponsor sponsor = context.Sponsors.Find(id);
                    context.Sponsors.Remove(sponsor);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Sponsor getByName(string name) {
            try
            {
                using (Context context = new Context())
                {
                    return context.Sponsors.Where(sponsor => sponsor.Name == name).FirstOrDefault();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}