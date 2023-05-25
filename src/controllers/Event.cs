using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public static class Event
    {
        public static void store(string date, string description, int userId, int placeId, int typeId)
        {
            DateOnly date = DateOnly.Parse(date);
            if (date == null)
            {
                throw new Exception("Date cannot be empty");
            }

            if (String.IsNullOrEmpty(description))
            {
                throw new Exception("Description cannot be empty");
            }

            if (userId < 0 || userId > Models.User.Last().Id)
            {
                throw new Exception("User id cannot be empty");
            }

            if (placeId < 0 || placeId > Models.Place.Last().Id)
            {
                throw new Exception("Place id cannot be empty");
            }

            if (typeId < 0 || typeId > Models.Type.Last().Id)
            {
                throw new Exception("Type id cannot be empty");
            }

            Models.Event.store(date, description, userId, placeId, typeId);
        }

        public static IEnumerable<Models.Event> index()
        {
            return Models.Event.index();
        }

        public static Models.Event show(int id)
        {
            Models.Event LastEvent = Models.Event.Last();
            if (id < 0 || LastEvent.Id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Event.show(id);
        }

        public static void update(string id, string date, string description, int userId, int placeId, int typeId)
        {
            int id = Int32.Parse(id);
            DateOnly date = DateOnly.Parse(date);

            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            if (date == null)
            {
                throw new Exception("Date cannot be empty");
            }

            if (String.IsNullOrEmpty(description))
            {
                throw new Exception("Description cannot be empty");
            }

            if (userId < 0 || userId > Models.User.Last().Id)
            {
                throw new Exception("User id cannot be empty");
            }

            if (placeId < 0 || placeId > Models.Place.Last().Id)
            {
                throw new Exception("Place id cannot be empty");
            }

            if (typeId < 0 || typeId > Models.Type.Last().Id)
            {
                throw new Exception("Type id cannot be empty");
            }

            Models.Event.update(id, date, description, userId, placeId, typeId);
        }

        public static void delete(string id)
        {
            int id = Int32.Parse(id);

            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }

            Models.Event.delete(id);


        }

    }
}