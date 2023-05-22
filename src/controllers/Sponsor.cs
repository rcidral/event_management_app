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

        public List<Models.Sponsor> index()
        {
            try
            {
                return Models.Sponsor.index();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Sponsor show(int id)
        {
            Sponsor sponsor = (
                from Sponsor in Sponsor.index()
                where Sponsor.id == id
                select Sponsor
            ).First();

            if (sponsor == null)
            {
                throw new Exception("Sponsor not found");
            }

            return sponsor;
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