using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ModelAttribute : System.Attribute
{
    public ModelAttribute() { }
    public ModelAttribute(string label)
    {
        this.Label = label;
    }
    private bool _Required = false;
    public bool Required
    {
        get { return _Required; }
        set { _Required = value; }
    }

    private string _Label = "";
    public string Label
    {
        get { return _Label; }
        set { _Label = value; }
    }

    private string _Helpblock;

    public string Helpblock
    {
        get { return _Helpblock; }
        set { _Helpblock = value; }
    }

    private string _Placeholder;

    public string Placeholder
    {
        get { return _Placeholder; }
        set { _Placeholder = value; }
    }


    private int _MaxLength = 0;
    public int MaxLength
    {
        get { return _MaxLength; }
        set { _MaxLength = value; }
    }

    private int _MinLength = 0;
    public int MinLength
    {
        get { return _MinLength; }
        set { _MinLength = value; }
    }

}
