using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class ArtistEventController
    {

        public static void store(Models.Artist artistId, ArtistEvent artistEvent)
        {
            if (artistId != null || artistEvent != null)
            {
                Models.ArtistEvent.store(new Models.ArtistEvent(artistId.Id, artistEvent.Id));
            }
        }

        public static List<ArtistEvent> index()
        {
            try
            {
                return Models.ArtistEvent.index();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, ArtistEvent artistEvent)
        {
            if (id != null || artistEvent != null)
            {
                Models.ArtistEvent.update(id, artistEvent);
            }
        }

        public static void delete(int id)
        {
            if (id != null)
            {
                Models.ArtistEvent.delete(id);
            }
        }

        public static List<Models.ArtistEvent> showByActualMonth()
        {
            try
            {
                return Models.ArtistEvent.showByActualMonth();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }


    }
}