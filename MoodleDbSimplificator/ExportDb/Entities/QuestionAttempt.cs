namespace MoodleDbSimplificator.ExportDb.Entities;

public class QuestionAttempt
{
    public long QuestionAttemptId { get; set; }
    
    public long QuestionId { get; set; }
    public Question? Question { get; set; }
    
    public long QuizAttemptId { get; set; }
    public QuizAttempt? QuizAttempt { get; set; }
    
    public QuestionBehaviour Behaviour { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public IList<QuestionAttemptStep>? Steps { get; set; }
}
