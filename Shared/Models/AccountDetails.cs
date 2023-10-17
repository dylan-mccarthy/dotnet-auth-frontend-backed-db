namespace AstroApp.Shared.Models;

public class AccountDetails {
    public int Id {get; set;}
    public string Username {get; set;}
    public string Email {get; set;}

    public int UploadCount {get; set;}

    public AccountDetails(string Username, string Email)
    {
        this.Username = Username;
        this.Email = Email;
        this.UploadCount = 0;
    }
}