using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Identifies gradable areas where advanced grading can happen.
/// </summary>
public partial class MdlGradingArea
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string Component { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string? Activemethod { get; set; }
}
