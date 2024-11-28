using CA2MusicTobyZedomi.Components.Pages;

namespace CA2MusicTobyZedomi.Music
{
    public class News : IComparable<News>
    {

        private rss? feed;
        private string section;
        private MusicArticleNews? theArticle;

        public News()
        {
            this.feed = NewsService.geRSSFeedsMusic();
        }

        public News(string section)
        {
            this.theArticle = NewsService.SearchMusicNews(section);
        }

        public rss? Feed { get => feed; set => feed = value; }
        public string Section { get => section; set => section = value; }
        public MusicArticleNews? TheArticle { get => theArticle; set => theArticle = value; }



        //compareToMethod
        public int CompareTo(News other)
        {

            int result = string.Compare(feed.channel.title, other.feed.channel.title, ignoreCase: true);
            if (result != 0)
            {
                result = string.Compare(feed.channel.title, other.feed.channel.title, ignoreCase: true);
            }

            return result;
        }


    }
}
