using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Place{

            public void store(string name, string address){
                if(String.IsNullOrEmpty(name))
                {
                    throw new Exception("Nome não pode ser vazio");
                }
                if(String.IsNullOrEmpty(address))
                {
                    throw new Exception("Endereço não pode ser vazio");
                }

                return new Place(name, address);
            }

               public List<Models.Place> index(){
                 try{
                      return Models.Place.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public static Place show(int id){
                        Place place = (
                            from Place in Place.index()
                            where Place.id == id
                            select Place
                        ).First();
    
                            if(place == null)
                            {
                                throw new Exception("Local não encontrado");
                        }
    
                            return place;
                 }

                 public void update(int id, Models.Place place){
                        Place place = Models.Place.show(id);

                        if(place == null)
                        {
                            throw new Exception("Local não encontrado");
                        }

                        if(String.IsNullOrEmpty(place.name))
                        {
                            throw new Exception("Nome não pode ser vazio");
                        }

                        if(String.IsNullOrEmpty(place.address))
                        {
                            throw new Exception("Endereço não pode ser vazio");
                        }

                        Models.Place.update(id, place);
                 }

                 public void delete(int id){
                        Place place = Models.Place.show(id);

                        if(place == null)
                        {
                            throw new Exception("Local não encontrado");
                        }

                        Models.Place.delete(id);
                 }

                 
        }
    }