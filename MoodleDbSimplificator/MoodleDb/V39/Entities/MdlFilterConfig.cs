using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores per-context configuration settings for filters which 
/// </summary>
public partial class MdlFilterConfig
{
    public long Id { get; set; }

    public string Filter { get; set; } = null!;

    public long Contextid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
