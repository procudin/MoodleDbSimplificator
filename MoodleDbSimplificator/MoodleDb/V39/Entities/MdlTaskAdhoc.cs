using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// List of adhoc tasks waiting to run.
/// </summary>
public partial class MdlTaskAdhoc
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public long Nextruntime { get; set; }

    public long? Faildelay { get; set; }

    public string? Customdata { get; set; }

    public long? Userid { get; set; }

    public sbyte Blocking { get; set; }
}
