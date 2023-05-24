using System;
using System.Collections.Generic;
using Models;
using System.Text.RegularExpressions;

namespace Controllers
{

    public class User
    {

        public static void store(string name, string login, string password)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            if (String.IsNullOrEmpty(login))
            {
                throw new Exception("Login cannot be empty");
            }
            if (String.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be empty");
            }

            Models.User.store(name, login, password);
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

        public static update(string id, string name, string login, string password)
        {
            int id = int32.Parse(id);
            if (id < 0 || id > Models.User.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.User.update(id, name, login, password);
        }



        public static delete(string id)
        {
            int id = int32.Parse(id);
            if (id < 0 || id > Models.User.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.User.delete(id);
        }
    }
}
