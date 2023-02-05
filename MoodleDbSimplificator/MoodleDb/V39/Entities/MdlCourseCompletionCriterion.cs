using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Course completion criteria
/// </summary>
public partial class MdlCourseCompletionCriterion
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Criteriatype { get; set; }

    public string? Module { get; set; }

    public long? Moduleinstance { get; set; }

    public long? Courseinstance { get; set; }

    public long? Enrolperiod { get; set; }

    public long? Timeend { get; set; }

    public decimal? Gradepass { get; set; }

    public long? Role { get; set; }
}
