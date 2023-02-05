using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Info about upgraded assignments
/// </summary>
public partial class MdlAssignmentUpgrade
{
    public long Id { get; set; }

    public long Oldcmid { get; set; }

    public long Oldinstance { get; set; }

    public long Newcmid { get; set; }

    public long Newinstance { get; set; }

    public long Timecreated { get; set; }
}
