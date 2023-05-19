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
                Event events = new Event(new DateOnly(2021, 10, 10), "Test", 1, 1, 1);
                Event.store(events, 1);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}