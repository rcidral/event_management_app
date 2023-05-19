using Data;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        public static void store(User user)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static List<User> index()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Users.ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static List<User> show(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Users.Where(user => user.Id == id).ToList();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static void update(int id, User user)
        {
            try
            {
                using (Context context = new Context())
                {
                    User userToUpdate = context.Users.Find(id);
                    userToUpdate.Name = user.Name;
                    userToUpdate.Login = user.Login;
                    userToUpdate.Password = user.Password;
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