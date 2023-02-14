using Microsoft.EntityFrameworkCore;

namespace MoodleDbSimplificator.ExportDb.Entities;

public class QuestionAttemptStep
{
    public long QuestionAttemptStepId { get; set; }
    
    public long QuestionAttemptId { get; set; }
    public QuestionAttempt? QuestionAttempt { get; set; }
    
    public long Order { get; set; }
    public string State { get; set; } = null!;
    public Dictionary<string, string>? Data { get; set; }
    public DateTime CreatedAt { get; set; }
}
