
namespace CA2MusicTobyZedomi.Music
{
    public abstract class MusicArtist
    {
        private string artistName;
        private Artists? theArtist;
        private Artist?[] theTopArtist;


        public MusicArtist(string artistName)
        {
            this.artistName = artistName;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }


        public MusicArtist()
        {

            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }

        public string ArtistName { get => artistName; set => artistName = value; }
        public Artists? TheArtist { get => theArtist; set => theArtist = value; }
        public Artist?[] TheTopArtist { get => theTopArtist; set => theTopArtist = value; }



        public override string? ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is MusicArtist artist &&
                   ArtistName == artist.ArtistName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArtistName);
        }
    }
}
