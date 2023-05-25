using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{

    public class Type
    {

        public static void store(string Description)
        {
            if (String.IsNullOrEmpty(Description))
            {
                throw new Exception("Description cannot be empty");


            }
            Models.Type.store(Description);
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

        public static void update(string id, string Description)
        {
            int id = int32.Parse(id);
            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            if (String.IsNullOrEmpty(Description))
            {
                throw new Exception("Description cannot be empty");
            }
            Models.Type.update(id, Description);
        }

        public static void delete(string id)
        {
            int id = int32.Parse(id);
            if (id < 0 || id == null)
            {
                throw new Exception("Id not found");
            }
            Models.Type.delete(id);
        }
    }
}