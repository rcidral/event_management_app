using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Artist{

            public void store(Models.Artist artist){
                try{
                    Models.Artist.store(artist);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.Artist> index(){
                 try{
                      return Models.Artist.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.Artist> show(int id){
                     try{
                          return Models.Artist.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.Artist artist){
                     try{
                          Models.Artist.update(id, artist);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.Artist.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 
        }
    }