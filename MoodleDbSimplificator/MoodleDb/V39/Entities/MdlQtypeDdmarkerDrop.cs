using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// drop regions
/// </summary>
public partial class MdlQtypeDdmarkerDrop
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long No { get; set; }

    public string? Shape { get; set; }

    public string Coords { get; set; } = null!;

    public long Choice { get; set; }
}
