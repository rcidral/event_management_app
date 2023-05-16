using Microsoft.EntityFrameworkCore;

namespace Data {
    public class Context : DbContext {
        public string connection = "Server=localhost;User Id=root;Database=event_management";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
}