using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class Artist
    {

        public void store(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }

            return Models.Artist.store(name);
        }

        public IEnumerable<Models.Artist> index()
        {
            return Models.Artist.index();
        }

        public Models.Artist show(int id)
        {
            Model.Artist LastArtist = Models.Artist.Last();
            if (id < 0 || LastArtist.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Artist.show(id);
        }

        public static void update(string id, string name)
        {
            int id = Convert.ToInt32(id);
            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }

            Models.Artist.update(id, name);
        }

        public static void delete(string id)
        {
            int id = Convert.ToInt32(id);

            if (id == null)
            {
                throw new Exception("Artist not found");
            }

            Models.Artist.delete(id);


        }
    }
}