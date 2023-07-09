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

            public static Models.Type show(int id)
            {
                try
                {
                    return Models.Type.show(id);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }

            public static void update(string id,Models.Type type)
            {
                if (type.Id != null || String.IsNullOrEmpty(type.Description) )
                {
                   Models.Type.update(Int32.Parse(id), type);
                }  
            }

            public static void delete(string id)
            {
                int Id = Convert.ToInt32(id);

                if (Id != null)
                {
                    Models.Type.delete(Id);
                }
            }

            public static Models.Type getByDescription(string description)
            {
                if (!String.IsNullOrEmpty(description))
                {
                    return Models.Type.getByDescription(description);
                }
                else
                {
                    return null;
                }
            }
        }
   }