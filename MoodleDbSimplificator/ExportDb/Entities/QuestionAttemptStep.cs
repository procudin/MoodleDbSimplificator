using Microsoft.EntityFrameworkCore;

namespace MoodleDbSimplificator.ExportDb.Entities;

public enum QuestionAttemptStepState
{
    Undefined,
    
    CorrectAnswer,
    IncorrectAnswer,
    
    HintWhatIs,
    HintWherePic,
    HintWhereText,
    HintNextLexem,
    HintNextChar,
}


public class QuestionAttemptStep
{
    public long QuestionAttemptStepId { get; set; }
    
    public long QuestionAttemptId { get; set; }
    public QuestionAttempt? QuestionAttempt { get; set; }
    
    public long Order { get; set; }
    
    public QuestionAttemptStepState State { get; set; }
    
    public string RawState { get; set; } = null!;
    public Dictionary<string, string>? RawStateData { get; set; }
    public DateTime CreatedAt { get; set; }
}
