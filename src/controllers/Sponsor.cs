using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Sponsor{

            public void store(Models.Sponsor sponsor){
                try{
                    Models.Sponsor.store(sponsor);
                }catch(System.Exception e){
                    throw e;
                }
            }

               public List<Models.Sponsor> index(){
                 try{
                      return Models.Sponsor.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.Sponsor> show(int id){
                     try{
                          return Models.Sponsor.show(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void update(int id, Models.Sponsor sponsor){
                     try{
                          Models.Sponsor.update(id, sponsor);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 public void delete(int id){
                     try{
                          Models.Sponsor.delete(id);
                     }catch(System.Exception e){
                          throw e;
                     }
                 }

                 
        }
    }