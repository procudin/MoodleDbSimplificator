using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// entries alias
/// </summary>
public partial class MdlGlossaryAlias
{
    public long Id { get; set; }

    public long Entryid { get; set; }

    public string Alias { get; set; } = null!;
}
