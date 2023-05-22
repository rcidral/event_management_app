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
                throw new Exception("Nome não pode ser vazio");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("Email não pode ser vazio");
            }
            if (String.IsNullOrEmpty(senha))
            {
                throw new Exception("Senha não pode ser vazio");
            }

            return new User(name, email, senha);

        }

        public List<Models.User> index()
        {
            try
            {
                return Models.User.index();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static User show(int id)
        {
            User user = (
               from User in User.index()
               where User.id == id
               select User
            ).First();

            if (user == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            return user;
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
