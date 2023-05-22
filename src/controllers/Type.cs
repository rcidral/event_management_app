using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Type
    {

        public static store(string Description)
        {
            if (String.IsNullOrEmpty(Description))
            {
                throw new Exception("Description cannot be empty");
            }

            return new Type(Description);
        }

        public List<Models.Type> index()
        {
            try
            {
                return Models.Type.index();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static Type show(int id)
        {
            Type type = (
                from Type in Type.index()
                where Type.id == id
                select Type
            ).First();

            if (type == null)
            {
                throw new Exception("Type not found");
            }
            return type;
        }

        public static update(int id, string Description)
        {
            Type type = Models.Type.show(id);
            if (!String.IsNullOrEmpty(type.Description))
            {
                Description = Description;
            }
            return type;
        }

        public static delete(int id)
        {
            Type type = Models.Type.show(id);
            Models.Type.delete(type);

            return type;
        }
    }
}