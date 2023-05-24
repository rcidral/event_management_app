using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    
    public class ArtistEvent
    {
        public void store(int artistId, int eventId)
        {
            if (artistId == null)
            {
                throw new Exception("Artist cannot be empty");
            }
            if (eventId == null)
            {
                throw new Exception("Event cannot be empty");
            }
            return new ArtistEvent(artistId, eventId);

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

        public static void update(string id )
        {
            int id = int32.Parse(id);
            if(id < 0 || id > Models.ArtistEvent.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.ArtistEvent.update(id);
        }

        public static void delete(int id)
        {
            if(id < 0 || id > Models.ArtistEvent.Last().Id)
            {
                throw new Exception("Id not found");
            }
            Models.ArtistEvent.delete(id);
        }          
    }
}