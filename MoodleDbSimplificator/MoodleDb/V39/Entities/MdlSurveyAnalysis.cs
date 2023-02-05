using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// text about each survey submission
/// </summary>
public partial class MdlSurveyAnalysis
{
    public long Id { get; set; }

    public long Survey { get; set; }

    public long Userid { get; set; }

    public string Notes { get; set; } = null!;
}
