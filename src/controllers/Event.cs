using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class EventControllers
    {

        public static void store(Event event_, int artistId, int sponsorId, Values values)
        {
            if (event_ != null || artistId != null || sponsorId != null || values != null)
            {
                Models.Event.store(event_, artistId, sponsorId, values);
            }
        }


        public static List<Models.Event> index()
        {
            return Models.Event.index();
        }

        public static Models.Event show(int id)
        {
            if (id != null)
            {
                return Models.Event.show(id);
            }
            else
            {
                return null;
            }
        }

        public static void update(string Id, Models.Event event_, int artistId, int sponsorId, Models.Values values)
        {
            try
            {
                int id = Int32.Parse(Id);
                if (id != null || event_ != null || artistId != null || sponsorId != null || values != null)
                {
                    Models.Event.update(id, event_, artistId, sponsorId, values);
                }

            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(int id)
        {
            if (id != null)
            {
                Models.Event.delete(id);
            }

        }
    }
}
