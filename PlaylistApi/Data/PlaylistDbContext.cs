using Microsoft.EntityFrameworkCore;
using PlaylistApi.Models;

namespace PlaylistApi.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options) { }

        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Track>().HasData(
                new Track
                {
                    Id = 1,
                    Title = "The Less I Know The Better",
                    Artist = "Tame Impala",
                    Length = 216,
                    Album = "Currents",
                    Category = "Indie"
                },
                new Track
                {
                    Id = 2,
                    Title = "Dreams",
                    Artist = "Fleetwood Mac",
                    Length = 256,
                    Album = "Rumours",
                    Category = "Rock"
                },
                new Track
                {
                    Id = 3,
                    Title = "Dancing Queen",
                    Artist = "ABBA",
                    Length = 227,
                    Album = "Arrival",
                    Category = "Pop"
                },
                new Track
                {
                    Id = 4,
                    Title = "Bohemian Rhapsody",
                    Artist = "Queen",
                    Length = 354,
                    Album = "A Night at the Opera",
                    Category = "Rock"
                }
                );
        }
    }
}
