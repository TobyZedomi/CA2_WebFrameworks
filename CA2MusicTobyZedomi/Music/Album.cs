using CA2MusicTobyZedomi.Components.Pages;

namespace CA2MusicTobyZedomi.Music
{
    public class Album : MusicArtist, IComparable<Album>, IMostPopular
    {


        private string albumName;
        private SearchAlbum? theAlbum;
        private Album5?[] theTopAlbums;
        private TopArtistCountry? theCountry;


        public Album(string albumName, string artistName) : base(artistName)
        {
            AlbumName = albumName;
            TheAlbum = MusicService.SearchForAlbum(albumName);
            //  TheTopAlbums = MusicService.GetTopAlbum().topalbums.album;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }



        public Album()
        {
            TheTopAlbums = MusicService.GetTopAlbum().topalbums.album;
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }

        // getters and setters

        public string AlbumName { get => albumName; set => albumName = value; }
        public SearchAlbum? TheAlbum { get => theAlbum; set => theAlbum = value; }
        public Album5?[] TheTopAlbums { get => theTopAlbums; set => theTopAlbums = value; }
        public TopArtistCountry? TheCountry { get => theCountry; set => theCountry = value; }


        /*

        // equals and hash
        public override bool Equals(object? obj)
        {
            if (!(obj is Song))
            {
                return false;
            }
            var userAlbum = (Album)obj;
            if (userAlbum.albumName.Equals(albumName) && userAlbum.ArtistName.Equals(ArtistName))
            {

                return true;

            }
            return false;
        }


        public static bool operator ==(Album left, Album right)
        {
            return !left.Equals(right);
        }

        public static bool operator !=(Album left, Album right)
        {
            return !left.Equals(right);
        }


        public override int GetHashCode()
        {
            return (albumName, ArtistName).GetHashCode();
        }

        */






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

        public TopArtistCountry? mostPopularArtistByCountry(string country)
        {
          
            theCountry = MusicService.getTopArtistByCountry(country);

            return theCountry;
        }


    }

}
