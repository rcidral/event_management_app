using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Place
    {

        public void store(string name, string address)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            if (String.IsNullOrEmpty(address))
            {
                throw new Exception("Address cannot be empty");
            }

            return new Place(name, address);
        }

        public List<Models.Place> index()
        {
            try
            {
                return Models.Place.index();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Place show(int id)
        {
            Place place = (
                from Place in Place.index()
                where Place.id == id
                select Place
            ).First();

            if (place == null)
            {
                throw new Exception("Place not found");
            }

            return place;
        }

        public void update(int id, Models.Place place)
        {
            Place place = Models.Place.show(id);

            if (place == null)
            {
                throw new Exception("Place not found");
            }

            if (String.IsNullOrEmpty(place.name))
            {
                throw new Exception("Name cannot be empty");
            }

            if (String.IsNullOrEmpty(place.address))
            {
                throw new Exception("Address cannot be empty");
            }

            Models.Place.update(id, place);
        }

        public void delete(int id)
        {
            Place place = Models.Place.show(id);

            if (place == null)
            {
                throw new Exception("Place not found");
            }

            Models.Place.delete(id);
        }
    }
}