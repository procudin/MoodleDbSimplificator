using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Setting for external badges display
/// </summary>
public partial class MdlBadgeExternal
{
    public long Id { get; set; }

    public long Backpackid { get; set; }

    public long Collectionid { get; set; }

    public string? Entityid { get; set; }

    public string? Assertion { get; set; }
}
