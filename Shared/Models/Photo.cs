
namespace AstroApp.Shared.Models;

public class Photo
{
    public int Id {get; set;}
    public string FileName {get; set;}
    public string Description {get; set;}
    public string Username {get; set;}

    public Photo(string fileName, string description, string username)
    {
        FileName = fileName;
        Description = description;
        Username = username;
    }
}