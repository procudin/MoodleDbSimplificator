using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Register of user actions over predictions.
/// </summary>
public partial class MdlAnalyticsPredictionAction
{
    public long Id { get; set; }

    public long Predictionid { get; set; }

    public long Userid { get; set; }

    public string Actionname { get; set; } = null!;

    public long Timecreated { get; set; }
}
