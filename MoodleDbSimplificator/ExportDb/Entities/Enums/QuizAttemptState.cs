namespace MoodleDbSimplificator.ExportDb.Entities.Enums;

public enum QuizAttemptState
{
    InProgress,
    Overdue,
    Finished,
    Abandoned,
}

public static class QuizAttemptStateParser
{
    public static QuizAttemptState Parse(string input)
    {
        return input switch
        {
            "inprogress" => QuizAttemptState.InProgress,
            "overdue" => QuizAttemptState.Overdue,
            "finished" => QuizAttemptState.Finished,
            "abandoned" => QuizAttemptState.Abandoned,
            _ => throw new ArgumentException($"Unexpected AttemptState '{input}'"),
        };
    }

    public static bool TryParse(string? input, out QuizAttemptState result)
    {
        try
        {
            result = Parse(input!);
            return true;
        }
        catch (Exception)
        {
            result = default;
            return false;
        }
    }
    
    
}
