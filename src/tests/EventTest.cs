using Models;
using Data;

namespace Test
{
    public class EventTest
    {
        public static void store()
        {
            try
            {
                Event event_ = new Event(new DateOnly(2021, 10, 10), "Test", 1, 1, 1);
                Event.store(event_, 1, 1, new Values(new DateOnly(2021, 10, 10), 1, 1, 1));
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}