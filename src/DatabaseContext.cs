using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class Context : DbContext
    {
        public string connection = "Server=localhost;User Id=root;Database=event_management";
        public DbSet<User> Users { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ArtistEvent> ArtistEvents { get; set; }
        public DbSet<Models.Values> ValuesEvent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
}