using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class ValuesController
    {

        public static void store(Values values)
        {
            if (values.Date != null || values.Value != null || values.SponsorId != null || values.EventId != null)
            {
                Models.Values.store(values);
            }

        }

        public static Values showByEventId(int id)
        {
            if (id != null)
            {
                return Models.Values.showByEventId(id);
            }
            else
            {
                return null;
            }
        }



        public static void update(int id, Models.Values values)
        {
            try
            {
                if (values.Date != null || values.Value != null || values.SponsorId != null || values.EventId != null)
                {
                    Models.Values.update(values.Id, values);
                }

            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(string Id)
        {
            int id = Int32.Parse(Id);
            if (id > 0 || id != null)
            {
                Models.Values.delete(id);
            }

        }
    }
}