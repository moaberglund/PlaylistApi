using System.ComponentModel.DataAnnotations;

namespace PlaylistApi.Models
{
    public class Track
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Artist { get; set; }

        [Required]
        public int? Length { get; set; }

        // One-to-One relationship
        public Streams? Streams { get; set; }


        // One-to-Many relationship
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }


        // Many-to-Many relationship
        public List<Genre>? Genres { get; set; }
    }
}
