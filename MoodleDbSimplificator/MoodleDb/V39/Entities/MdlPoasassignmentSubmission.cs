using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Saves submission data
/// </summary>
public partial class MdlPoasassignmentSubmission
{
    public long Id { get; set; }

    public long? Answerid { get; set; }

    public string? Value { get; set; }

    public long? Attemptid { get; set; }
}
