namespace MoodleDbSimplificator.ExportDb.Entities;

public enum UserSex
{
    Male,
    Female,
}

public class User
{
    public long UserId { get; set; }
    public string Username { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public UserSex? Sex { get; set; }
    public string Country { get; set; } = null!;
    public string Lang { get; set; } = null!;
    public DateTime Firstaccess { get; set; }
    public DateTime Lastaccess { get; set; }
}
