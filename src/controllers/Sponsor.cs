using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Sponsor
    {

        public static store(string name)
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

        public static update(int id, string name)
        {
            Sponsor sponsor = Models.Sponsor.show(id);

            if (!String.IsNullOrEmpty(name))
            {
                sponsor.name = name;
            }
            return sponsor;
        }

        public static delete(int id)
        {
            Sponsor sponsor = Models.Sponsor.show(id);
            Models.Sponsor.delete(id);

            return sponsor;
        }
    }
}