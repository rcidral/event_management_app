namespace Models
{
    public class User
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Login { get; set;}
        public string Password { get; set;}

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    }
}