namespace MoodleDbSimplificator.ExportDb.Entities;

public class Question
{
    public long QuestionId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string CategoryDescription { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Type { get; set; } = null!;
    public decimal DefaultMark { get; set; }
    public decimal Penalty { get; set; }
}
