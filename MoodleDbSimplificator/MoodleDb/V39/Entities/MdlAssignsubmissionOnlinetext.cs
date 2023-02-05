using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Info about onlinetext submission
/// </summary>
public partial class MdlAssignsubmissionOnlinetext
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Submission { get; set; }

    public string? Onlinetext { get; set; }

    public short Onlineformat { get; set; }
}
