using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores rotation information of a page.
/// </summary>
public partial class MdlAssignfeedbackEditpdfRot
{
    public long Id { get; set; }

    public long Gradeid { get; set; }

    public long Pageno { get; set; }

    public string Pathnamehash { get; set; } = null!;

    public bool Isrotated { get; set; }

    public long Degree { get; set; }
}
