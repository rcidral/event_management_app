using Data;

namespace Models
{
    public class Type{
        public int Id { get; set; }
        public string Description { get; set; }

        public Type(string description){
            Description = description;
        }

        public static void store(Type type){
            try{
                using(Context context = new Context()){
                    context.Types.Add(type);
                    context.SaveChanges();
                }
            }catch(System.Exception e){
                throw e;
            }
        }

        public static List<Type> index(){
            try{
                using(Context context = new Context()){
                    return context.Types.ToList();
                }
            }catch(System.Exception e){
                throw e;
            }
        }

        public static Type show(int id){
            try{
                using(Context context = new Context()){
                    return context.Types.Find(id);
                }
            }catch(System.Exception e){
                throw e;
            }
        }

        public static void update(int id, Type type){
            try{
                using(Context context = new Context()){
                    Type t = context.Types.Find(id);
                    t.Description = type.Description;
                    context.SaveChanges();
                }
            }catch(System.Exception e){
                throw e;
            }
        }

        public static void delete(int id){
            try{
                using(Context context = new Context()){
                    Type type = context.Types.Find(id);
                    context.Types.Remove(type);
                    context.SaveChanges();
                }
            }catch(System.Exception e){
                throw e;
            }
        }

    }
}