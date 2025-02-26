using Microsoft.EntityFrameworkCore;
using PlaylistApi.Models;

namespace PlaylistApi.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options) { }

        public DbSet<Track> Tracks { get; set; }
        public DbSet<Streams> Streams { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Track>().HasData(
                new Track
                {
                    Id = 1,
                    Title = "The Less I Know The Better",
                    Artist = "Tame Impala",
                    Length = 216
                },
                new Track
                {
                    Id = 2,
                    Title = "Dreams",
                    Artist = "Fleetwood Mac",
                    Length = 256
                },
                new Track
                {
                    Id = 3,
                    Title = "Dancing Queen",
                    Artist = "ABBA",
                    Length = 227
                },
                new Track
                {
                    Id = 4,
                    Title = "Bohemian Rhapsody",
                    Artist = "Queen",
                    Length = 354
                }
                );
        }
    }
}
