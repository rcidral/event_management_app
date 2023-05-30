using Models;

namespace Test
{
    public class ValuesTest
    {
        public static void store(Models.Values values)
        {
            try
            {
                Models.Values.store(new Models.Values(values.Date, values.Value, values.SponsorId, values.EventId));
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, Models.Values values)
        {
            try
            {
                Models.Values.update(id, values);
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
                Models.Values.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}