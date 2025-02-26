
namespace PlaylistApi.Models
{
    public class Album
    {
        public int Id { get; set; }

        public required string AlbumTitle { get; set; }

        public int? Year { get; set; }

        public string? Studio { get; set; }

        // Relationship - id GET songs on the album
        public List<Track>? Tracks { get; set; }

    }
}
