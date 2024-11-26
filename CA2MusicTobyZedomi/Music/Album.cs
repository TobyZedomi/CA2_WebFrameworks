using CA2MusicTobyZedomi.Components.Pages;

namespace CA2MusicTobyZedomi.Music
{
    public class Album : MusicArtist
    {


        private string albumName;
        private SearchAlbum? theAlbum;
        private Album5?[] theTopAlbums;



        public Album(string albumName, string artistName) : base(artistName)
        {
            AlbumName = albumName;
            TheAlbum = MusicService.SearchForAlbum(albumName);
            TheTopAlbums = MusicService.GetTopAlbum().topalbums.album;
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;
        }

        public string AlbumName { get => albumName; set => albumName = value; }
        public SearchAlbum? TheAlbum { get => theAlbum; set => theAlbum = value; }
        public Album5?[] TheTopAlbums { get => theTopAlbums; set => theTopAlbums = value; }

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

        public override string ToString()
        {
            return $"{{{nameof(AlbumName)}={AlbumName}, {nameof(TheAlbum)}={TheAlbum}, {nameof(TheTopAlbums)}={TheTopAlbums}, {nameof(ArtistName)}={ArtistName}, {nameof(TheArtist)}={TheArtist}, {nameof(TheTopArtist)}={TheTopArtist}}}";
        }



    }
}
