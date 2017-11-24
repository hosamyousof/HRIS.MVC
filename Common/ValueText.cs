using System.Collections.Generic;

public class ValueText
{
    public ValueText()
    {
    }

    public ValueText(string value, string text)
    {
        this.Value = value;
        this.Text = text;
    }

    public ValueText(string value)
    {
        this.Value = "";
        this.Text = value;
    }


    public string Text { get; set; }

    public string Value { get; set; }

    public string Col1 { get; set; }
    public string Col2 { get; set; }
    public string Col3 { get; set; }
    public string Col4 { get; set; }

    public static List<ValueText> Convert(IEnumerable<ValueText> lst)
    {
        return Convert(lst, "");
    }

    public static List<ValueText> Convert(IEnumerable<ValueText> lst, string defaultDescription)
    {
        var list = new List<ValueText>();
        if (!string.IsNullOrEmpty(defaultDescription))
            list.Add(new ValueText() { Text = defaultDescription, Value = "-99" });
        foreach (var item in lst)
        {
            list.Add(item);
        }
        return list;
    }
}