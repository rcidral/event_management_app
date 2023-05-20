using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class ArtistEvent{

            public void store(Models.ArtistEvent artistEvent){
                try{
                    Models.ArtistEvent.store(artistEvent);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.ArtistEvent> index(){
                 try{
                      return Models.ArtistEvent.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.ArtistEvent> show(int id){
                     try{
                          return Models.ArtistEvent.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.ArtistEvent artistEvent){
                     try{
                          Models.ArtistEvent.update(id, artistEvent);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.ArtistEvent.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 
        }
    }