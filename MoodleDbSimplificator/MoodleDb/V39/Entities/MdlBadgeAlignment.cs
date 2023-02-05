using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines alignment for badges
/// </summary>
public partial class MdlBadgeAlignment
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public string Targetname { get; set; } = null!;

    public string Targeturl { get; set; } = null!;

    public string? Targetdescription { get; set; }

    public string? Targetframework { get; set; }

    public string? Targetcode { get; set; }
}
