using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Steps in an tour
/// </summary>
public partial class MdlToolUsertoursStep
{
    public long Id { get; set; }

    public long Tourid { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public sbyte Targettype { get; set; }

    public string Targetvalue { get; set; } = null!;

    public long Sortorder { get; set; }

    public string Configdata { get; set; } = null!;
}
