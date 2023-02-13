using MoodleDbSimplificator.ExportDb.Entities.Enums;

namespace MoodleDbSimplificator.ExportDb.Entities;

public class QuizAttempt
{
    public long QuizAttemptId { get; set; }
    
    public long QuizId { get; set; }
    public Quiz? Quiz { get; set; }
    
    public long UserId { get; set; }
    public User? User { get; set; }
    
    public int AttemptNumber { get; set; }

    public QuizAttemptState State { get; set; }
    
    public DateTime TimeStart { get; set; }
    public DateTime TimeFinish { get; set; }
    
    public decimal? SumGrades { get; set; }
}
