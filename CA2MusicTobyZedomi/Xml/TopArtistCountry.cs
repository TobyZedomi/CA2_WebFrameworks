
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class TopArtistCountry
{

    private lfmTopartists topartistsField;

    private string statusField;

    /// <remarks/>
    public lfmTopartists topartists
    {
        get
        {
            return this.topartistsField;
        }
        set
        {
            this.topartistsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopartists
{

    private lfmTopartistsArtist[] artistField;

    private string countryField;

    private byte pageField;

    private byte perPageField;

    private ushort totalPagesField;

    private uint totalField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("artist")]
    public lfmTopartistsArtist[] artist
    {
        get
        {
            return this.artistField;
        }
        set
        {
            this.artistField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte page
    {
        get
        {
            return this.pageField;
        }
        set
        {
            this.pageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte perPage
    {
        get
        {
            return this.perPageField;
        }
        set
        {
            this.perPageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort totalPages
    {
        get
        {
            return this.totalPagesField;
        }
        set
        {
            this.totalPagesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopartistsArtist
{

    private string nameField;

    private uint listenersField;

    private string mbidField;

    private string urlField;

    private byte streamableField;

    private lfmTopartistsArtistImage[] imageField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public uint listeners
    {
        get
        {
            return this.listenersField;
        }
        set
        {
            this.listenersField = value;
        }
    }

    /// <remarks/>
    public string mbid
    {
        get
        {
            return this.mbidField;
        }
        set
        {
            this.mbidField = value;
        }
    }

    /// <remarks/>
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public byte streamable
    {
        get
        {
            return this.streamableField;
        }
        set
        {
            this.streamableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("image")]
    public lfmTopartistsArtistImage[] image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopartistsArtistImage
{

    private string sizeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

