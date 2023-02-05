using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// stores what outcomes are used in what courses.
/// </summary>
public partial class MdlGradeOutcomesCourse
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Outcomeid { get; set; }
}
