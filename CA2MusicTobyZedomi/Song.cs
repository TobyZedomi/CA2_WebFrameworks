


namespace CA2MusicTobyZedomi
{
    public class Song : MusicArtist, IComparable<Song>
    {

        private string songName;
        private SearchSong? theSong;
        private Track3?[] theTopSongs;

        public Song(string songName, string artistName) : base(artistName)
        {
            this.SongName = songName;
            TheSong = MusicService.SearchForSong(songName);
            TheTopSongs = MusicService.GetTopSong().tracks.track;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }



        public Song()
        {
            TheTopSongs = MusicService.GetTopSong().tracks.track;
            TheTopArtist = MusicService.GetTopArtists().artists.artist;


        }


        public string SongName { get => songName; set => songName = value; }
        public SearchSong? TheSong { get => theSong; set => theSong = value; }
        public Track3?[] TheTopSongs { get => theTopSongs; set => theTopSongs = value; }

      

        /*
        public override bool Equals(object? obj)
        {
            if (!(obj is Song))
            {
                return false;
            }
            var userSong = (Song)obj;
            if (userSong.songName.Equals(songName) && userSong.ArtistName.Equals(ArtistName))
            {

                return true;

            }
            return false;
        }


        public static bool operator ==(Song left, Song right)
        {
            return !left.Equals(right);
        }

        public static bool operator !=(Song left, Song right)
        {
            return !left.Equals(right);
        }


        public override int GetHashCode()
        {
            return (songName, ArtistName).GetHashCode();
        }

        */




        /// compareTo method
        /// 

        public int CompareTo(Song other)
        {

            int result = string.Compare(songName, other.songName, ignoreCase: true);
            if (result != 0)
            {
                result = string.Compare(ArtistName, other.ArtistName, ignoreCase: true);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{{{nameof(SongName)}={SongName}, {nameof(TheSong)}={TheSong}, {nameof(TheTopSongs)}={TheTopSongs}, {nameof(ArtistName)}={ArtistName}, {nameof(TheArtist)}={TheArtist}, {nameof(TheTopArtist)}={TheTopArtist}}}";
        }


        // equals and hash

        public override bool Equals(object? obj)
        {
            return obj is Song song &&
                   ArtistName == song.ArtistName &&
                   songName == song.songName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArtistName, songName);
        }
    }
}
