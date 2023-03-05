namespace MoodleDbSimplificator.ExportDb.Entities;

public class QuizGrade
{
    public long QuizId { get; set; }
    public Quiz? Quiz { get; set; }
    
    public long UserId { get; set; }
    public User? User { get; set; }
    
    public decimal Grade { get; set; }
    public DateTime UpdatedAt { get; set; }
}
