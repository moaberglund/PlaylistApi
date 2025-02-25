using Microsoft.EntityFrameworkCore;
using PlaylistApi.Models;

namespace PlaylistApi.Data
{
    public class PlaylistDbContext(DbContextOptions<PlaylistDbContext> options) : DbContext(options)
    {
        public DbSet<Track> Tracks { get; set; }
    }
}
