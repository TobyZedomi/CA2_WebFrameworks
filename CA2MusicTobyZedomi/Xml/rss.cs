
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class rss
{

    private rssChannel channelField;

    private decimal versionField;

    /// <remarks/>
    public rssChannel channel
    {
        get
        {
            return this.channelField;
        }
        set
        {
            this.channelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannel
{

    private string titleField;

    private string linkField;

    private link link1Field;

    private object descriptionField;

    private string languageField;

    private string copyrightField;

    private string lastBuildDateField;

    private string pubDateField;

    private rssChannelImage imageField;

    private rssChannelItem[] itemField;

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Namespace = "http://www.w3.org/2005/Atom")]
    public link link1
    {
        get
        {
            return this.link1Field;
        }
        set
        {
            this.link1Field = value;
        }
    }

    /// <remarks/>
    public object description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public string language
    {
        get
        {
            return this.languageField;
        }
        set
        {
            this.languageField = value;
        }
    }

    /// <remarks/>
    public string copyright
    {
        get
        {
            return this.copyrightField;
        }
        set
        {
            this.copyrightField = value;
        }
    }

    /// <remarks/>
    public string lastBuildDate
    {
        get
        {
            return this.lastBuildDateField;
        }
        set
        {
            this.lastBuildDateField = value;
        }
    }

    /// <remarks/>
    public string pubDate
    {
        get
        {
            return this.pubDateField;
        }
        set
        {
            this.pubDateField = value;
        }
    }

    /// <remarks/>
    public rssChannelImage image
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public rssChannelItem[] item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
public partial class link
{

    private string hrefField;

    private string relField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rel
    {
        get
        {
            return this.relField;
        }
        set
        {
            this.relField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelImage
{

    private string titleField;

    private string urlField;

    private string linkField;

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
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
    public string link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItem
{

    private string titleField;

    private string linkField;

    private rssChannelItemGuid guidField;

    private link link1Field;

    private string descriptionField;

    private string creatorField;

    private string pubDateField;

    private rssChannelItemCategory[] categoryField;

    private content contentField;

    private string creditField;

    private string description1Field;

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }

    /// <remarks/>
    public rssChannelItemGuid guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link", Namespace = "http://www.w3.org/2005/Atom")]
    public link link1
    {
        get
        {
            return this.link1Field;
        }
        set
        {
            this.link1Field = value;
        }
    }

    /// <remarks/>
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
    public string creator
    {
        get
        {
            return this.creatorField;
        }
        set
        {
            this.creatorField = value;
        }
    }

    /// <remarks/>
    public string pubDate
    {
        get
        {
            return this.pubDateField;
        }
        set
        {
            this.pubDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("category")]
    public rssChannelItemCategory[] category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://search.yahoo.com/mrss/")]
    public content content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://search.yahoo.com/mrss/")]
    public string credit
    {
        get
        {
            return this.creditField;
        }
        set
        {
            this.creditField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://search.yahoo.com/mrss/")]
    public string description1
    {
        get
        {
            return this.description1Field;
        }
        set
        {
            this.description1Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItemGuid
{

    private bool isPermaLinkField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isPermaLink
    {
        get
        {
            return this.isPermaLinkField;
        }
        set
        {
            this.isPermaLinkField = value;
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItemCategory
{

    private string domainField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string domain
    {
        get
        {
            return this.domainField;
        }
        set
        {
            this.domainField = value;
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
public partial class content
{

    private ushort heightField;

    private string mediumField;

    private string urlField;

    private ushort widthField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string medium
    {
        get
        {
            return this.mediumField;
        }
        set
        {
            this.mediumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }
}

