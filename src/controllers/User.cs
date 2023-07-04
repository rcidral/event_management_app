using System;
using System.Collections.Generic;
using Models;
using System.Text.RegularExpressions;



namespace Controllers
{
    public class UserController
    {
        public static void store(User user)
        {
           /* if (String.IsNullOrEmpty(user.Name))
            {
                throw new Exception("Name cannot be empty");
            }*/
            if (String.IsNullOrEmpty(user.Login))
            {
                throw new Exception("Login cannot be empty");
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Password cannot be empty");
            }
            Models.User.store(user);
        }       


        public static List<Models.User> Index()
        {
            return User.index();
        }



        public static List<User> show(string UserId)
        {
            try
            {
                int Id = Int32.Parse(UserId);
                return Models.User.show(Id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }


        public static void Update(int id, User user)
        {
            if(String.IsNullOrEmpty(user.Name)){
                throw new Exception ("Is not Name or empty");
            }
            if(String.IsNullOrEmpty(user.Login))
            {
                throw new Exception ("Is not Login or empty");                
            }
            User.update(id, user);
        }


        public static void Delete(int id)
        {
            try
            {
                Models.User.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Boolean login(string login, string password)
        {
            if (String.IsNullOrEmpty(login))
            {
                throw new Exception("Login cannot be empty");
            }
            if (String.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be empty");
            }
            return Models.User.login(login, password);
        }

        public static int nextId()
        {
            try
            {
                return Models.User.LastId();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static User getUserByName(string name)     
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            return Models.User.getUserByName(name);
        }

    }
}