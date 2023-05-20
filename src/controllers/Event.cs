using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Event{

            public void store(Models.Event @event){
                try{
                    Models.Event.store(@event);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.Event> index(){
                 try{
                      return Models.Event.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.Event> show(int id){
                     try{
                          return Models.Event.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.Event @event){
                     try{
                          Models.Event.update(id, @event);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.Event.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 
        }
    }
