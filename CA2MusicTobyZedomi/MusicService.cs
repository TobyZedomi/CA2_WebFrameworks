using RestSharp;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace CA2MusicTobyZedomi
{
    public class MusicService
    {


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

    }


}

