
public class TopSongCountry
{
    public Tracks6 tracks { get; set; }
}

public class Tracks6
{
    public Track6[] track { get; set; }
    public Attr6 attr { get; set; }
}

public class Attr6
{
    public string country { get; set; }
    public string page { get; set; }
    public string perPage { get; set; }
    public string totalPages { get; set; }
    public string total { get; set; }
}

public class Track6
{
    public string name { get; set; }
    public string duration { get; set; }
    public string listeners { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
    public Streamable6 streamable { get; set; }
    public Artist6 artist { get; set; }
    public Image6[] image { get; set; }
    public Attr16 attr { get; set; }
}

public class Streamable6
{
    public string text { get; set; }
    public string fulltrack { get; set; }
}

public class Artist6
{
    public string name { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
}

public class Attr16
{
    public string rank { get; set; }
}

public class Image6
{
    public string text { get; set; }
    public string size { get; set; }
}
