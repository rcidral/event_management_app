using Models;

namespace Test
{
    public class ValuesTest
    {
        public static void store(Values values)
        {
            try
            {
                Values values_ = new Values(values.Date, values.Value, values.SponsorId, values.EventId);
                Values.store(values_);
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
                Values.update(id, values);
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
                Values.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}