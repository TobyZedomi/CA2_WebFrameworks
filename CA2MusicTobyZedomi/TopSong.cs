
public class TopSong
{
    public Tracks tracks { get; set; }
}

public class Tracks
{
    public Track3[] track { get; set; }
    public Attr3 attr { get; set; }
}

public class Attr3
{
    public string page { get; set; }
    public string perPage { get; set; }
    public string totalPages { get; set; }
    public string total { get; set; }
}

public class Track3
{
    public string name { get; set; }
    public string duration { get; set; }
    public string playcount { get; set; }
    public string listeners { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
    public Streamable streamable { get; set; }
    public Artist3 artist { get; set; }
    public Image3[] image { get; set; }
}

public class Streamable
{
    public string text { get; set; }
    public string fulltrack { get; set; }
}

public class Artist3
{
    public string name { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
}

public class Image3
{
    public string text { get; set; }
    public string size { get; set; }
}
