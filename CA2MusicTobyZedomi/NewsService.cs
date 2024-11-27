using RestSharp;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace CA2MusicTobyZedomi
{
    public class NewsService
    {


        public static GetBook? getBookNames()
        {


            var client = new RestClient("https://api.nytimes.com/svc/books/v3/lists/names.json?");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "names.json";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "bgzqxUI7eDsNfCNHUjhvVnS3HZlJVXSs";
            request.AddParameter("api-key", myKey);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                GetBook? topArtists = JsonConvert.DeserializeObject<GetBook>(receivedJson);
                return topArtists;

            }

            return null;

        }


        //searchTopStories

        public static TopStories? SearchTopStories(string section)
        {
            var client = new RestClient("https://api.nytimes.com/svc/topstories/v2/");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "{section}.json";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "bgzqxUI7eDsNfCNHUjhvVnS3HZlJVXSs";
            request.AddParameter("api-key", myKey);
            request.AddParameter("section", section);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                TopStories? topStories = JsonConvert.DeserializeObject<TopStories>(receivedJson);
                return topStories;

            }

            return null;
        }


        /// search for artist information
        /// 

        public static ArtistNews? SearchArtistNews(string artist)
        {
            var client = new RestClient("https://api.nytimes.com/svc/search/v2/articlesearch.json?");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "{section}.json";
            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            string myKey = "bgzqxUI7eDsNfCNHUjhvVnS3HZlJVXSs";
            request.AddParameter("api-key", myKey);
            request.AddParameter("q", artist);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                string receivedJson = response.Content;
                ArtistNews? topStories = JsonConvert.DeserializeObject<ArtistNews>(receivedJson);
                return topStories;

            }

            return null;
        }

    }
}
