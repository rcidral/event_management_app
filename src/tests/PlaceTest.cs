using Models;

namespace Test
{
    public class PlaceTest
    {
        public static void store()
        {
            try
            {
                Place place = new Place("Test", "test");
                Place.store(place);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}