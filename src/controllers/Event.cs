using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class EventControllers
    {

        public static void store(DateOnly date, string description, string user, string place, string type, string artistId, string sponsorId, Double values)
        {
            Models.Event.store(new Models.Event(date, description, 
                Controllers.UserController.getUserByName(user).Id, 
                Controllers.PlaceControllers.getPlaceByName(place).Id, 
                Controllers.TypeControllers.getByDescription(type).Id), artistId, sponsorId, values);
        }


        public static List<Models.Event> index()
        {
            return Models.Event.index();
        }

        public static List<Models.Event> show(int id)
        {
            try
            {
                return Models.Event.show(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

       /* public static void update(DateOnly date, string description, string user, string place, string type, string artistId, string sponsorId, Double values)
        {
            Models.Event.update(new Models.Event(date, description, 
                Controllers.UserController.getUserByName(user).Id, 
                Controllers.PlaceControllers.getPlaceByName(place).Id, 
                Controllers.TypeControllers.getByDescription(type).Id), artistId, sponsorId, values);
        }*/

        public static void delete(int id)
        {
            if (id != null)
            {
                Models.Event.delete(id);
            }

        }
    }
}
