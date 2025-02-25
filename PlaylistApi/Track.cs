using System.ComponentModel.DataAnnotations;

namespace PlaylistApi
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

        [Required]
        public string? Album { get; set; }

        public string? Category { get; set; }
    }
}
