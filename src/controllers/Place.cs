using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Place{

            public void store(Models.Place place){
                try{
                    Models.Place.store(place);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.Place> index(){
                 try{
                      return Models.Place.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.Place> show(int id){
                     try{
                          return Models.Place.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.Place place){
                     try{
                          Models.Place.update(id, place);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.Place.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 
        }
    }