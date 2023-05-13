namespace MoodleDbSimplificator.ExportDb.Entities;

public class ExamGrade
{
    public long UserId { get; set; }
    public User? User { get; set; }
    
    public long CourseId { get; set; }
    public Course? Course { get; set; }
    
    public decimal? RawGrade { get; set; }
    public decimal? RawNormalizedGrade { get; set; }
    public decimal? TotalGrade { get; set; }
}
