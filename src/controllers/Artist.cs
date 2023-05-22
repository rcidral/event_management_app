using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class Artist{

            public void store(string name){
                if(String.IsNullOrEmpty(name))
                {
                    throw new Exception("Nome não pode ser vazio");
                }

                return Models.Artist.store(name);
            }

               public List<Models.Artist> index(){
                 try{
                      return Models.Artist.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.Artist> show(int id){
                        Artist artist = (
                            from Artist in Artist.index()
                            where Artist.id == id
                            select Artist
                        ).First();
    
                            if(artist == null)
                            {
                                throw new Exception("Artista não encontrado");
                        }
    
                            return artist;
                 }

                 public void update(int id, Models.Artist artist){
                        Artist artist = Models.Artist.show(id);

                        if(!String.IsNullOrEmpty(artist.name))
                        {
                            artist.name = artist.name;
                        }
                 }

                 public static delete(int id){
                        Artist artist = Artist.show(id);

                        if(artist == null)
                        {
                            throw new Exception("Artista não encontrado");
                        }

                        Models.Artist.delete(id);

                        return artist;
                 }

                 
        }
    }