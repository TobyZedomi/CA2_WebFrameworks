
public class TopAlbum
{
    public Topalbums topalbums { get; set; }
}

public class Topalbums
{
    public Album5[] album { get; set; }
    public Attr attr { get; set; }
}

public class Attr5
{
    public string artist { get; set; }
    public string page { get; set; }
    public string perPage { get; set; }
    public string totalPages { get; set; }
    public string total { get; set; }
}

public class Album5
{
    public string name { get; set; }
    public int playcount { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
    public Artist artist { get; set; }
    public Image[] image { get; set; }
}

public class Artist5
{
    public string name { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
}

public class Image5
{
    public string text { get; set; }
    public string size { get; set; }
}
