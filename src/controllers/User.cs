using System;
using System.Collections.Generic;
using Models;
using System.Text.RegularExpressions;

    namespace Controllers{

        public class User{

            public void store(string nome, string email, string senha){
                if(String.IsNullOrEmpty(nome))
                {
                    throw new Exception("Nome não pode ser vazio");
                }
                if(String.IsNullOrEmpty(email))
                {
                    throw new Exception("Email não pode ser vazio");
                }
                if(String.IsNullOrEmpty(senha))
                {
                    throw new Exception("Senha não pode ser vazio");
                }

                return Models.User.store(nome, email, senha);
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

                 public void update(int id, string nome, string email, string senha){
                        User user = Models.User.show(id);

                        if(user == null)
                        {
                            throw new Exception("Usuário não encontrado");
                        }

                        if(String.IsNullOrEmpty(nome))
                        {
                            throw new Exception("Nome não pode ser vazio");
                        }
                        if(String.IsNullOrEmpty(email))
                        {
                            throw new Exception("Email não pode ser vazio");
                        }
                        if(String.IsNullOrEmpty(senha))
                        {
                            throw new Exception("Senha não pode ser vazio");
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
    