
public class SearchSong
{
    public Results2 results { get; set; }
}

public class Results2
{
    public OpensearchQuery2 opensearchQuery { get; set; }
    public string opensearchtotalResults { get; set; }
    public string opensearchstartIndex { get; set; }
    public string opensearchitemsPerPage { get; set; }
    public Trackmatches trackmatches { get; set; }
    public Attr attr { get; set; }
}

public class OpensearchQuery2
{
    public string text { get; set; }
    public string role { get; set; }
    public string startPage { get; set; }
}

public class Trackmatches
{
    public Track[] track { get; set; }
}

public class Track
{
    public string name { get; set; }
    public string artist { get; set; }
    public string url { get; set; }
    public string streamable { get; set; }
    public string listeners { get; set; }
    public Image2[] image { get; set; }
    public string mbid { get; set; }
}

public class Image2
{
    public string text { get; set; }
    public string size { get; set; }
}

public class Attr2
{
}
