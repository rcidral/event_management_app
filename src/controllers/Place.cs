using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Place
    {

        public static store(string name, string address)
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

        public IEnumerable<Models.Place> index()
        {
            return Models.Place.index();
        }

        public Models.Place show(int id)
        {
            Model.Place LastPlace = Models.Place.Last();
            if (id < 0 || LastPlace.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Place.show(id);
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