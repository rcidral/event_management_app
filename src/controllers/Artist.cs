using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class Artist
    {

        public static void store(Models.Artist artist)
        {
            if (!String.IsNullOrEmpty(artist.Name))
            {
                Models.Artist.store(artist);
            }
           
             
        }
       

        public static IEnumerable<Models.Artist> index()
        {
            return Models.Artist.index();
        }

        public static Models.Artist show(int id)
        {
            
            if(id != null)
            {
               return Models.Artist.show(id);
            }else{
                return null;
            }

            
        }

        public static void update(Models.Artist artist)
        {
            
            if (artist.Id != null || String.IsNullOrEmpty(artist.Name) )
            {
               Models.Artist.update(artist.Id , artist);
            }
            

            
        }

        public static void delete(string id)
        {
            int Id = Convert.ToInt32(id);

            if (Id != null)
            {
                Models.Artist.delete(Id);
            }

            


        }
    }
}