namespace CA2MusicTobyZedomi.Music
{
    public class Song : MusicArtist, IComparable<Song>, IMostPopularSong
    {

        private string songName;
        private string artist;
        private SearchSong? theSong;
        private Track3?[] theTopSongs;
        private TopSongCountry? theCountry;
        private string country;

        public Song(string songName, string artist, string artistName) : base(artistName)
        {
            SongName = songName;
            Artist = artist;
            TheSong = MusicService.SearchForSong(songName, artist);
            TheTopSongs = MusicService.GetTopSong().tracks.track;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }



        public Song()
        {
            TheTopSongs = MusicService.GetTopSong().tracks.track;
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }

        public Song(string country)
        {
            this.country = country;
        }


        public string SongName { get => songName; set => songName = value; }
        public SearchSong? TheSong { get => theSong; set => theSong = value; }
        public Track3?[] TheTopSongs { get => theTopSongs; set => theTopSongs = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Country { get => country; set => country = value; }
        public TopSongCountry? TheCountry { get => theCountry; set => theCountry = value; }



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

            int result = string.Compare(artist, other.artist, ignoreCase: true);
            if (result != 0)
            {
                result = string.Compare(songName, other.songName, ignoreCase: true);
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
                   artist == song.artist &&
                   songName == song.songName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(artist, songName);
        }



        // interface method

        public TopSongCountry? mostPopularSongByCountry()
        {

            TheCountry = MusicService.getTopSongByCountry(country);


            return TheCountry;
        }
    }
}
