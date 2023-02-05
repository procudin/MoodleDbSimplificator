using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines parameters for badges criteria
/// </summary>
public partial class MdlBadgeCriteriaParam
{
    public long Id { get; set; }

    public long Critid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
