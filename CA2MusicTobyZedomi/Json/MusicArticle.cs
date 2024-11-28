
public class MusicArticle
{
    public string status { get; set; }
    public string copyright { get; set; }
    public int num_results { get; set; }
    public Result7[] results { get; set; }
}

public class Result7
{
    public string slug_name { get; set; }
    public string section { get; set; }
    public string subsection { get; set; }
    public string title { get; set; }
    public string _abstract { get; set; }
    public string uri { get; set; }
    public string url { get; set; }
    public string byline { get; set; }
    public string item_type { get; set; }
    public string source { get; set; }
    public DateTime updated_date { get; set; }
    public DateTime created_date { get; set; }
    public DateTime published_date { get; set; }
    public DateTime first_published_date { get; set; }
    public string material_type_facet { get; set; }
    public string kicker { get; set; }
    public string subheadline { get; set; }
    public string[] des_facet { get; set; }
    public string[] org_facet { get; set; }
    public string[] per_facet { get; set; }
    public string[] geo_facet { get; set; }
    public Related_Urls[] related_urls { get; set; }
    public Multimedia7[] multimedia { get; set; }
}

public class Related_Urls
{
    public string suggested_link_text { get; set; }
    public string url { get; set; }
}

public class Multimedia7
{
    public string url { get; set; }
    public string format { get; set; }
    public int height { get; set; }
    public int width { get; set; }
    public string type { get; set; }
    public string subtype { get; set; }
    public string caption { get; set; }
    public string copyright { get; set; }
}

