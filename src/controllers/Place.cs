using System;
using System.Collections.Generic;
using Models;

    namespace Controllers
    {
        public class PlaceControllers
        {
            public static void store(Models.Place place)
            {
                if (!String.IsNullOrEmpty(place.Name))
                {
                    Models.Place.store(place);
                }
                
            }

            public static List<Models.Place> index()
            {
                return Models.Place.index();
            }

            public static Models.Place show(string PlaceId)
            {
                try
                {
                    int Id = Int32.Parse(PlaceId);
                    return Models.Place.show(Id);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }

            public static void update(string IdPlace,Models.Place place)
            {
                try
                {
                    int id = Int32.Parse(IdPlace);
                    if (!String.IsNullOrEmpty(place.Name))
                    {
                        Models.Place.update(id, place);
                    }
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
                    throw new Exception("Id cannot be empty");
                }
                Models.Place.delete(id);
            }
        }
    }