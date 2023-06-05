using System;
using System.Collections.Generic;
using Models;

   namespace Controllers
   {
        public class TypeControllers
        {
            public static void store(Models.Type type)
            {
                if (!String.IsNullOrEmpty(type.Description))
                {
                    Models.Type.store(type);
                }
                
            }

            public static List<Models.Type> index()
            {
                return Models.Type.index();
            }

            public static Models.Type show(string Id)
            {
                try
                {
                    int id = Int32.Parse(Id);
                    return Models.Type.show(id);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }

            public static void update(string IdType,Models.Type type)
            {
                try
                {
                    int id = Int32.Parse(IdType);
                    if (!String.IsNullOrEmpty(type.Description))
                    {
                        Models.Type.update(id, type);
                    }
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }

            public static void delete(int id)
            {
                if (id < 0 || id == null)
                {
                    throw new Exception("Id cannot be empty");
                }
                Models.Type.delete(id);
            }
        }
   }