using System;
using System.Collections.Generic;
using Models;
using System.Text.RegularExpressions;

namespace Controllers
{

    public class User
    {

        public static store(string name, string email, string senha)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty ");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("Email cannot be empty");
            }
            if (String.IsNullOrEmpty(senha))
            {
                throw new Exception("Password cannot be empty");
            }
            return new User(name, email, senha);
        }

        public static IEnumerable<Models.User> index()
        {
            return Models.User.index();
        }

        public static Models.User show(int id)
        {
            Model.User LastUser = Models.User.Last();
            if (id < 0 || LastUser.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.User.show(id);
        }

        public static update(int id, string name, string email, string senha)
        {
            User user = Models.User.show(id);

            if (!String.IsNullOrEmpty(name))
            {
                user.name = name;
            }
            if (!String.IsNullOrEmpty(email))
            {
                user.email = email;
            }
            if (!String.IsNullOrEmpty(senha))
            {
                user.senha = senha;
            }

            return user;
        }
        public static delete(int id)
        {
            User user = Models.User.show(id);
            Models.User.delete(user);
            return user;
        }
    }
}
