using RestSharp;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace CA2MusicTobyZedomi
{
    public class MusicService
    {

        // search for artist

        public static Artists? SearchForArtist(string artist)
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "artist.search";
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";

            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            request.AddParameter("api_key", myKey);
            request.AddParameter("artist", artist);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                Artists? theArtist = JsonConvert.DeserializeObject<Artists>(receivedJson);
                return theArtist;

            }
            return null;
        }


        /// Get top artist

        public static TopArtist? GetTopArtists()
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "chart.getTopArtists";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";
            request.AddParameter("api_key", myKey);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                TopArtist? topArtists = JsonConvert.DeserializeObject<TopArtist>(receivedJson);
                return topArtists;

            }

            return null;

        }


        // search Song

        public static SearchSong? SearchForSong(string track, string artist)
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "track.search";
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";

            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            request.AddParameter("api_key", myKey);
            request.AddParameter("track", track);
            request.AddParameter("artist", artist);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                SearchSong? theSong = JsonConvert.DeserializeObject<SearchSong>(receivedJson);
                return theSong;

            }
            return null;
        }

        // get top track 

        public static TopSong? GetTopSong()
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "chart.getTopTracks";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";
            request.AddParameter("api_key", myKey);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                TopSong? topSongs = JsonConvert.DeserializeObject<TopSong>(receivedJson);
                return topSongs;

            }

            return null;

        }


        // search for album, xml 


        public static SearchAlbum? SearchForAlbum(string track)
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "album.search";
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";

            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            request.AddParameter("api_key", myKey);
            request.AddParameter("track", track);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                SearchAlbum? theAlbum = JsonConvert.DeserializeObject<SearchAlbum>(receivedJson);
                return theAlbum;

            }
            return null;
        }


        // get top album, xml

        public static TopAlbum? GetTopAlbum()
        {

            var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "artist.getTopAlbums";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "833c3bfe07b3b78ddd9a75eaff0ccaaf";
            request.AddParameter("api_key", myKey);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                TopAlbum? topAlbums = JsonConvert.DeserializeObject<TopAlbum>(receivedJson);
                return topAlbums;

            }

            return null;

        }


        /// get lyrics from artist and song 
        /// 

        public static ArtistLyrics? GetLyrics(string artist, string title)
        {



           var client = new RestClient("https://api.lyrics.ovh/v1/");
            var request = new RestRequest();

           // string Myuser = "test";
            //string myMethod = "lyrics.ovh";
           // request.AddParameter("method", myMethod);
           // request.AddParameter("user", Myuser);
            request.AddParameter("artist", artist);
            request.AddParameter("title", title);
          //  request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                ArtistLyrics? topLyrics = JsonConvert.DeserializeObject<ArtistLyrics>(receivedJson);
                return topLyrics;

            }

            return null;

        }

    }


}

