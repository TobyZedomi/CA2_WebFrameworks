using CA2MusicTobyZedomi.Components.Pages;

namespace CA2MusicTobyZedomi.Music
{
    public class Album : MusicArtist, IComparable<Album>, IMostPopularAlbum
    {

       // private string artistName;
        private string albumName;
        private SearchAlbum? theAlbum;
        private Album5?[] theTopAlbums;
        private lfm? theCountry;
        private string country;


        public Album(string albumName, string artistName) : base(artistName)
        {
            this.albumName = albumName;
            TheAlbum = MusicService.SearchForAlbum(albumName);
          //  TheTopAlbums = MusicService.GetTopAlbum().topalbums.album;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }


        public Album()
        {
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }

        /*
        public Album(string artistName)
        {
            this.artistName = artistName;
            TheTopAlbums = MusicService.GetTopAlbum(artistName).topalbums.album;
        }

        */

        public Album(string country)
        {
            this.country = country;
        }

        // getters and setters

        public string AlbumName { get => albumName; set => albumName = value; }
        public SearchAlbum? TheAlbum { get => theAlbum; set => theAlbum = value; }
        public Album5?[] TheTopAlbums { get => theTopAlbums; set => theTopAlbums = value; }
        public lfm? TheCountry { get => theCountry; set => theCountry = value; }
        public string Country { get => country; set => country = value; }
       // public string ArtistName { get => artistName; set => artistName = value; }


        /// compareTo method


        public int CompareTo(Album other)
        {

            int result = string.Compare(ArtistName, other.ArtistName, ignoreCase: true);
            if (result != 0)
            {
                result = string.Compare(albumName, other.albumName, ignoreCase: true);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{{{nameof(AlbumName)}={AlbumName}, {nameof(TheAlbum)}={TheAlbum}, {nameof(TheTopAlbums)}={TheTopAlbums}, {nameof(ArtistName)}={ArtistName}, {nameof(TheArtist)}={TheArtist}, {nameof(TheTopArtist)}={TheTopArtist}}}";
        }


        //equals and hash
        public override bool Equals(object? obj)
        {
            return obj is Album album &&
                   ArtistName == album.ArtistName &&
                   albumName == album.albumName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArtistName, albumName);
        }

        // interface method

        public lfm? mostPopularArtistByCountry()
        {
          
           theCountry = MusicService.getTopArtistByCountry(country);


            return theCountry;
        }


    }

}
