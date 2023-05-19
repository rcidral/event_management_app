using Models;

namespace Test
{
    public class UserTest
    {
        public static void store()
        {
            try
            {
                User user = new User("Test", "test", "test");
                User.store(user);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}