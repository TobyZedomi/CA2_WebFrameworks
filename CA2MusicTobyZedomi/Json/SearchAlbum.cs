
public class SearchAlbum
{
    public Results results { get; set; }
}

public class Results4
{
    public OpensearchQuery opensearchQuery { get; set; }
    public string opensearchtotalResults { get; set; }
    public string opensearchstartIndex { get; set; }
    public string opensearchitemsPerPage { get; set; }
    public Albummatches albummatches { get; set; }
    public Attr attr { get; set; }
}

public class OpensearchQuery4
{
    public string text { get; set; }
    public string role { get; set; }
    public string searchTerms { get; set; }
    public string startPage { get; set; }
}

public class Albummatches
{
    public Album[] album { get; set; }
}

public class Album
{
    public string name { get; set; }
    public string artist { get; set; }
    public string url { get; set; }
    public Image[] image { get; set; }
    public string streamable { get; set; }
    public string mbid { get; set; }
}

public class Image4
{
    public string text { get; set; }
    public string size { get; set; }
}

public class Attr4
{
    public string _for { get; set; }
}

