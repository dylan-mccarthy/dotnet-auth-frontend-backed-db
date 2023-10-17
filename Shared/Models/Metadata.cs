namespace AstroApp.Shared.Models;
public class MetaData
{
    public int Id {get; set;}
    public string Text {get; set;}
    public string Category {get; set;}
    public int PhotoId {get; set;}

    public MetaData(string text, string category, int photoId)
    {
        Text = text;
        Category = category;
        PhotoId = photoId;
    }
}