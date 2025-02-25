using Microsoft.EntityFrameworkCore;
using PlaylistApi.Models;

namespace PlaylistApi.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options) { }

        public DbSet<Track> Tracks { get; set; }

    }

}
