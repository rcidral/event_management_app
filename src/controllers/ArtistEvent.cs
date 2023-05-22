using System;
using System.Collections.Generic;
using Models;

    namespace Controllers{

        public class ArtistEvent{

            public void store(int artistId, int eventId){
                if(artistId == null)
                {
                    throw new Exception("Artista não pode ser vazio");
                }
                if(eventId == null)
                {
                    throw new Exception("Evento não pode ser vazio");
                }
                return new ArtistEvent(artistId, eventId);

            }

               public List<Models.ArtistEvent> index(){
                 try{
                      return Models.ArtistEvent.index();
                 }catch(System.Exception e){
                      throw e;
                 }
               }

                 public List<Models.ArtistEvent> show(int id){
                        ArtistEvent artistEvent = (
                            from ArtistEvent in ArtistEvent.index()
                            where ArtistEvent.id == id
                            select ArtistEvent
                        ).First();
        
                            if(artistEvent == null)
                            {
                                throw new Exception("Artista não encontrado");
                        }
        
                            return artistEvent;
                 }

                 public static update(int id, Models.ArtistEvent artistEvent){
                        ArtistEvent artistEvent = Models.ArtistEvent.show(id);

                        if(!String.IsNullOrEmpty(artistEvent.artistId))
                        {
                            artistEvent.artistId = artistEvent.artistId;
                        }
                        if(!String.IsNullOrEmpty(artistEvent.eventId))
                        {
                            artistEvent.eventId = artistEvent.eventId;
                        }

                        return artistEvent;
                 }

                 public static delete(int id){
                        ArtistEvent artistEvent = ArtistEvent.show(id);

                        Models.ArtistEvent.delete(id);

                        return artistEvent;
                 }

                 
        }
    }