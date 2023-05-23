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

        public static update(int id, Models.ArtistEvent artistEvent)
        {
            ArtistEvent artistEvent = Models.ArtistEvent.show(id);

            if (!String.IsNullOrEmpty(artistEvent.artistId))
            {
                artistEvent.artistId = artistEvent.artistId;
            }
            if (!String.IsNullOrEmpty(artistEvent.eventId))
            {
                artistEvent.eventId = artistEvent.eventId;
            }

            return artistEvent;
        }

        public static delete(int id)
        {
            ArtistEvent artistEvent = ArtistEvent.show(id);

            Models.ArtistEvent.delete(id);
            
            return artistEvent;
        }          
    }
}