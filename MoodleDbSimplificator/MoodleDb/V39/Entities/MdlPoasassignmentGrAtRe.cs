using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlPoasassignmentGrAtRe
{
    public long Id { get; set; }

    public long? Testid { get; set; }

    public long? Attemptid { get; set; }

    public string? Studentout { get; set; }

    public bool? Testpassed { get; set; }
}
