using Microsoft.EntityFrameworkCore;

namespace MoodleDbSimplificator.ExportDb.Entities;

public enum QuestionAttemptStepState
{
    Undefined,
    
    // ответ на вопрос
    Answer,
    RightAnswer,
    WrongAnswer,
    PartialCorrectAnswer,
    
    // запросы подсказок
    HintWhatIs,
    HintWherePic,
    HintWhereText,
    HintNextLexem,
    HintNextChar,
    
    // оценка попытки
    GaveUp,
    GradedRight,
    GradedWrong,
    GradedPartial,
}


public class QuestionAttemptStep
{
    public long QuestionAttemptStepId { get; set; }
    
    public long QuestionAttemptId { get; set; }
    public QuestionAttempt? QuestionAttempt { get; set; }
    
    public long Order { get; set; }
    
    public QuestionAttemptStepState State { get; set; }
    
    //public string RawState { get; set; } = null!;
    //public Dictionary<string, string>? RawStateData { get; set; }
    public DateTime CreatedAt { get; set; }
}
