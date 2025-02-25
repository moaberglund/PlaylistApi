namespace PlaylistApi.Models
{
    public class Streams
    {
        public int Id { get; set; }

        public int? SpotifyStreams { get; set; }

        public int? AppleMusicStreams { get; set; }

        public int? AmazonMusicStreams { get; set; }


        public int TrackId { get; set; }

    }
}
