using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class User{

            public void store(Models.User user){
                try{
                    Models.User.store(user);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.User> index(){
                 try{
                      return Models.User.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.User> show(int id){
                     try{
                          return Models.User.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.User user){
                     try{
                          Models.User.update(id, user);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.User.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }
        }
    }