namespace MoodleDbSimplificator.ExportDb.Entities;

public class QuizQuestion
{
    public long QuizId { get; set; }
    public Quiz? Quiz { get; set; }
    
    public long QuestionId { get; set; }
    public Question? Question { get; set; }
    
    public long Order { get; set; }
    public long PageNumber { get; set; }
    public bool RequirePrevious { get; set; }
}
