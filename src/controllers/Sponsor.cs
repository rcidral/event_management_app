using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Sponsor
    {

        public static void store(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");

                return new Sponsor(name);
            }
        }

        public static IEnumerable<Models.Sponsor> index()
        {
            return Models.Sponsor.index();
        }

        public static Models.Sponsor show(int id)
        {
            Model.Sponsor LastSponsor = Models.Sponsor.Last();
            if (id < 0 || LastSponsor.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Sponsor.show(id);
        }

        public static void update(int id, string name)
        {
            if (id < 0 || id > Models.Sponsor.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.Sponsor.update(id, name);    
        }

        public static void delete(int id)
        {
            if (id < 0 || id > Models.Sponsor.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.Sponsor.delete(id);
        }
    }
}