using Microsoft.EntityFrameworkCore;
using Models;

namespace Data {
    public class Context : DbContext {
        public string connection = "Server=localhost;User Id=root;Database=event_management";
        public DbSet<User> Users { get; set; }
        public DbSet<Place> Places { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
}