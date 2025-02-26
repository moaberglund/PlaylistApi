using System.Text.Json.Serialization;

namespace PlaylistApi.Models
{
    public class Genre
    {

        public int Id { get; set; }
        public required string GenreName { get; set; }

        [JsonIgnore]
        public List<Track>? Tracks { get; set; }
    }
}