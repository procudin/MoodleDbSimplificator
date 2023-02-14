namespace MoodleDbSimplificator.ExportDb.Entities;

public enum QuestionBehaviour
{
    /// <summary>
    /// Students must enter an answer to each question and then submit the entire quiz before anything is graded or they get any feedback.
    /// </summary>
    DeferredFeedback,
    
    /// <summary>
    /// Allows students to have multiple attempts at the question before moving on to the next question
    /// </summary>
    Adaptive,
    
    AdaptiveHint,
    
    Survey,
    
    /// <summary>
    /// Used for essay questions (irrespective of what the quiz is set to) but you can now choose to have every question in the quiz manually graded if you wish
    /// </summary>
    //Manual,
    
    /// <summary>
    /// Used for allowing multiple attempts on the same question (perhaps with a grade penalty)
    /// </summary>
    InteractiveMultipleTries,
    
    /// <summary>
    /// Similar to interactive mode in that the student can submit their response immediately during the quiz attempt, and get it graded. However, they can only submit one response, they cannot change it later.
    /// </summary>
    ImmediateFeedback,
    
    /// <summary>
    /// With CBM, the student does not only answer the question, but they also indicate how sure they are they got the question right. The grading is adjusted by the choice of certainty so that students have to reflect honestly on their own level of knowledge in order to get the best mark.
    /// </summary>
    DeferredFeedbackCBM,
    
    /// <summary>
    /// If using the Interactive with multiple tries or Immediate Feedback behaviour and with the navigation method set to 'Free', it is possible to make the display of a question dependent on a previous question being answered first
    /// </summary>
    ConditionalQuestions,
}

public static class QuestionBehaviourParser
{
    public static QuestionBehaviour Parse(string input)
    {
        return input switch
        {
            "deferredfeedback" => QuestionBehaviour.DeferredFeedback,
            "adaptive"         => QuestionBehaviour.Adaptive,
            "adaptivehints"    => QuestionBehaviour.AdaptiveHint,
            "survey"           => QuestionBehaviour.Survey,
            "interactive"      => QuestionBehaviour.InteractiveMultipleTries,
            _                  => throw new ArgumentException($"Unexpected behaviour '{input}'"),
        };
    }

    public static bool TryParse(string? input, out QuestionBehaviour result)
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

