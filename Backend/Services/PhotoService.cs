using AstroApp.Backend;
using Backend;
using Microsoft.EntityFrameworkCore;

namespace AstroApp.Backend.Services;

public interface IPhotoService
{
    string GetPhotoUrl(string fileName);
    void AddPhoto(string fileName, string description, string username);
    void DeletePhoto(string fileName);
}

public class PhotoService : IPhotoService
{
    private AstroappContext _dbContext;

    public PhotoService(AstroappContext astroappContext){
        _dbContext = astroappContext;
    }

    public void AddPhoto(string fileName, string description, string username)
    {
        _dbContext.Photos.Add(new Shared.Models.Photo(fileName, description, username));
    }

    public void DeletePhoto(string fileName)
    {
        var photo = _dbContext.Photos.Where(s => s.FileName == fileName).FirstOrDefault();
        if(photo != null)
        {
            _dbContext.Photos.Remove(photo);
        }
    }

    public string GetPhotoUrl(string fileName){
        //Integrate with Storage Account to get url for filename
        return "";
    }
}