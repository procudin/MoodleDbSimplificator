using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Setting for external badges mappings
/// </summary>
public partial class MdlBadgeExternalIdentifier
{
    public long Id { get; set; }

    public long Sitebackpackid { get; set; }

    public string Internalid { get; set; } = null!;

    public string Externalid { get; set; } = null!;

    public string Type { get; set; } = null!;
}
