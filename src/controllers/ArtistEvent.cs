using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class ArtistEvent
    {
        public static void store(int artistId, int eventId)
        {
            if (artistId == null)
            {
                throw new Exception("Artist cannot be empty");
            }
            if (eventId == null)
            {
                throw new Exception("Event cannot be empty");
            }
            Models.ArtistEvent.store(artistId, eventId);

        }

        public IEnumerable<Models.ArtistEvent> index()
        {
            return Models.ArtistEvent.index();
        }

        public Models.ArtistEvent show(int id)
        {
            Model.ArtistEvent LastArtistEvent = Models.ArtistEvent.Last();
            if (id < 0 || LastArtistEvent.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.ArtistEvent.show(id);
        }

        public static void update(string id)
        {
            int id = int32.Parse(id);
            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            Models.ArtistEvent.update(id);
        }

        public static void delete(string id)
        {
            int id = int32.Parse(id);
            if (id < 0 || id > id == null)
            {
                throw new Exception("Id not found");
            }
            Models.ArtistEvent.delete(id);
        }
    }
}