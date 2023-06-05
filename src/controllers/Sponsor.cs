using System;
using System.Collections.Generic;
using Models;
using System.Text.RegularExpressions;

namespace Controllers
{

    public class SponsorControllers
    {

        public static void store(Sponsor sponsor)
        {   
            if (String.IsNullOrEmpty(sponsor.Name))
            {
                throw new Exception("Name cannot be empty");

                
            }
            Models.Sponsor.store(sponsor);
        }

        public static List<Models.Sponsor> index()
        {
            return Models.Sponsor.index();
        }

        public static Sponsor show(string Id)
        {
            try
            {
                int id = Int32.Parse(Id);
                return Models.Sponsor.show(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, Models.Sponsor sponsor)
        {
            try
            {
                if (String.IsNullOrEmpty(sponsor.Name))
                {
                    throw new Exception("Name cannot be empty");
                }
                Models.Sponsor.update(id, sponsor);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(int id)
        {
            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            Models.Sponsor.delete(id);
        }
    }
}