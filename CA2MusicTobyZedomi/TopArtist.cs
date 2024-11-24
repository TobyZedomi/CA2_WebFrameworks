
public class TopArtist
{
    public Artists2 artists { get; set; }
}

public class Artists2
{
    public Artist[] artist { get; set; }
    public Attr attr { get; set; }
}

public class Attr1
{
    public string page { get; set; }
    public string perPage { get; set; }
    public string totalPages { get; set; }
    public string total { get; set; }
}

public class Artist1
{
    public string name { get; set; }
    public string playcount { get; set; }
    public string listeners { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
    public string streamable { get; set; }
    public Image[] image { get; set; }
}

public class Image1
{
    public string text { get; set; }
    public string size { get; set; }
}
