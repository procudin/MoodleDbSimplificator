using MoodleDbSimplificator.ExportDb.Entities.Enums;

namespace MoodleDbSimplificator.ExportDb.Entities;

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
    
    /// <summary>
    /// The total that the quiz overall grade is scaled to be out of.
    /// </summary>
    public decimal Grade { get; set; }
    
    /// <summary>
    /// The total of all the question instance maxmarks.
    /// </summary>
    public decimal SumGrades { get; set; }
    
    public IList<QuizGrade>? Grades { get; set; }
    public IList<QuizAttempt>? Attempts { get; set; }
    public IList<QuizQuestion>? Questions { get; set; }
}
