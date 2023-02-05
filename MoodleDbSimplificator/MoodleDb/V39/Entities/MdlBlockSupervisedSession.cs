using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Session events
/// </summary>
public partial class MdlBlockSupervisedSession
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Classroomid { get; set; }

    public long Groupid { get; set; }

    public long Teacherid { get; set; }

    public long Lessontypeid { get; set; }

    public long Timestart { get; set; }

    public long Duration { get; set; }

    public long Timeend { get; set; }

    public bool? State { get; set; }

    public bool? Sendemail { get; set; }

    public string? Sessioncomment { get; set; }

    public string Iplist { get; set; } = null!;
}
