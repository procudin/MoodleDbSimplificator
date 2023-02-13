namespace MoodleDbSimplificator.ExportDb.Entities;

public enum QuizGradeMethod
{
    HighestGrade = 1,
    AverageGrade = 2,
    FirstGrade   = 3,
    LastGrade    = 4,
}

public class Quiz
{
    public long QuizId { get; set; }
    
    public long CourceId { get; set; }
    public Course? Course { get; set; }

    public string Name { get; set; } = null!;
    public string? Intro { get; set; }
    
    public TimeSpan TimeLimit { get; set; }
    
    public QuestionBehaviour Behaviour { get; set; }
    public QuizGradeMethod GradeMethod { get; set; }
    
    public IList<QuizQuestion>? Questions { get; set; }
}
