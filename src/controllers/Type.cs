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

        public static IEnumerable<Models.Type> index()
        {
            return Models.Type.index();
        }

        public static Models.Type show(int id)
        {
            Model.Type LastType = Models.Type.Last();
            if (id < 0 || LastType.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Type.show(id);
        }

        public static Type show(int id)
        {
            Model.Type LastType = Models.Type.Last();
            if (id < 0 || LastType.id != id)
            {
                throw new Exception("Id not found");
            }
            return Models.Type.show(id);
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