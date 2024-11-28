using RestSharp;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace CA2MusicTobyZedomi
{
    public class NewsService
    {


        /// search for article information
        /// using this one

        public static MusicArticleNews? SearchMusicNews(string artist)
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
                MusicArticleNews? topStories = JsonConvert.DeserializeObject<MusicArticleNews>(receivedJson);
                return topStories;

            }

            return null;
        }



        //  Music rss feeds, xml file

        public static rss? geRSSFeedsMusic()
        {

            var client = new RestClient("https://rss.nytimes.com/services/xml/rss/nyt/music.xml");
            var request = new RestRequest();

            string Myuser = "test";
            string myMethod = "geo.getTopArtists";
            string myKey = "bgzqxUI7eDsNfCNHUjhvVnS3HZlJVXSs";

            request.AddParameter("method", myMethod);
            request.AddParameter("user", Myuser);
            request.AddParameter("api-key", myKey);
            request.AddParameter("limit", 10);
            request.AddParameter("format", "xml");

            var response = client.Get(request);

            if (!string.IsNullOrEmpty(response.Content))
            {

                var serializer = new XmlSerializer(typeof(rss));
                using (StringReader sr = new(response.Content))
                {
                    rss? filtered = (rss?)serializer.Deserialize(sr);
                    return filtered;
                }

            }
            return null;
        }



      



    }
}
