using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// This table contains one entry for every configured external 
/// </summary>
public partial class MdlRepository
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public bool? Visible { get; set; }

    public long Sortorder { get; set; }
}
