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

        public static update(int id, Models.Artist artist)
        {
            Artist artist = Models.Artist.show(id);

            if (!String.IsNullOrEmpty(artist.name))
            {
                artist.name = artist.name;
            }

            return Models.Artist.update(id, artist);
        }

        public static delete(int id)
        {
            Artist artist = Artist.show(id);

            if (artist == null)
            {
                throw new Exception("Artist not found");
            }

            Models.Artist.delete(id);

            return artist;
        }
    }
}