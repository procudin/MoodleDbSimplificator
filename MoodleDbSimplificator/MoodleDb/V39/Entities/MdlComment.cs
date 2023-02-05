using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// moodle comments module
/// </summary>
public partial class MdlComment
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string? Component { get; set; }

    public string Commentarea { get; set; } = null!;

    public long Itemid { get; set; }

    public string Content { get; set; } = null!;

    public sbyte Format { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }
}
