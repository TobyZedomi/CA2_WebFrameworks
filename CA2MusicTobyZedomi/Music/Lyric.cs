using CA2MusicTobyZedomi.Components.Pages;

namespace CA2MusicTobyZedomi.Music
{
    public class Lyric : MusicArtist, IComparable<Lyric>
    {


        private string artist;
        private string title;
        private ArtistLyrics? theLyrics;


        /*
        public Lyric(string artist, string title, string artistName) : base(artistName) 
        {
            this.Artist = artist;
            this.Title = title;
            TheLyrics = MusicService.GetLyrics(artist,title);
            TheArtist = MusicService.SearchForArtist(artistName);
            TheTopArtist = MusicService.GetTopArtists().artists.artist;

        }

        */

        public string Artist { get => artist; set => artist = value; }
        public string Title { get => title; set => title = value; }
        public ArtistLyrics? TheLyrics { get => theLyrics; set => theLyrics = value; }


        // equals and hash 


        public override bool Equals(object? obj)
        {
            if (!(obj is Lyric))
            {
                return false;
            }
            var userLyric = (Lyric)obj;
            if (userLyric.artist.Equals(artist) && userLyric.title.Equals(title))
            {

                return true;

            }
            return false;
        }


        public static bool operator ==(Lyric left, Lyric right)
        {
            return !left.Equals(right);
        }

        public static bool operator !=(Lyric left, Lyric right)
        {
            return !left.Equals(right);
        }


        public override int GetHashCode()
        {
            return (artist, title).GetHashCode();
        }


        // compareTo method 

        public int CompareTo(Lyric other)
        {

            int result = string.Compare(artist, other.artist, ignoreCase: true);
            if (result != 0)
            {
                result = string.Compare(title, other.title, ignoreCase: true);
            }

            return result;
        }

    }
}
