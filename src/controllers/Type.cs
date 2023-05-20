using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Type{

           public void store(Models.Type type){
               try{
                   Models.Type.store(type);
               }catch(System.Exception e){
                   throw e;
               }
           }

              public List<Models.Type> index(){
                try{
                     return Models.Type.index();
                }catch(System.Exception e){
                     throw e;
                }
              }

                public List<Models.Type> show(int id){
                    try{
                         return Models.Type.show(id);
                    }catch(System.Exception e){
                         throw e;
                    }
                }

                public void update(int id, Models.Type type){
                    try{
                         Models.Type.update(id, type);
                    }catch(System.Exception e){
                         throw e;
                    }
                }

                public void delete(int id){
                    try{
                         Models.Type.delete(id);
                    }catch(System.Exception e){
                         throw e;
                    }
                }

                
        }
    }