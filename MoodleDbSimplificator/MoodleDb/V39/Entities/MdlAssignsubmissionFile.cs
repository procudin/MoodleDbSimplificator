using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Info about file submissions for assignments
/// </summary>
public partial class MdlAssignsubmissionFile
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Submission { get; set; }

    public long Numfiles { get; set; }
}
