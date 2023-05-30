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
            if (String.IsNullOrEmpty(user.Name))
            {
                throw new Exception("Name cannot be empty");
            }
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



        public static IEnumerable<User> Index()
        {
            return User.index();
        }



        public static User show(string Id)
        {
            try
            {
                int id = Int32.Parse(Id);
                return Models.User.show(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }


        public static void Update(User user)
        {
            if(String.IsNullOrEmpty(user.Name)){
                throw new Exception ("Is not Name or empty");
            }
            if(String.IsNullOrEmpty(user.Login))
            {
                
            }

        }



        public static void Delete(string id)
        {
            int Id = Int32.Parse(id);
            if (Id != null)
            {
                Models.User.delete(Id);
            }



           
        }
    }
}