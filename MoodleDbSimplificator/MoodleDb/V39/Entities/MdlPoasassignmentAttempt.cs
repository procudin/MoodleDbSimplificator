using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlPoasassignmentAttempt
{
    public long Id { get; set; }

    public long? Assigneeid { get; set; }

    public long? Attemptnumber { get; set; }

    public decimal? Rating { get; set; }

    public long? Attemptdate { get; set; }

    public long? Ratingdate { get; set; }

    public bool? Disablepenalty { get; set; }

    public bool? Draft { get; set; }

    public bool? Final { get; set; }
}
