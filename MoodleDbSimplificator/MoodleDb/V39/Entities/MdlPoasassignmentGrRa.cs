using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for remote_autotester, please edit me
/// </summary>
public partial class MdlPoasassignmentGrRa
{
    public long Id { get; set; }

    public long Attemptid { get; set; }

    public long Timecreated { get; set; }

    public string Serverresponse { get; set; } = null!;

    public long? Timecompilestarted { get; set; }

    public long? Timecompiled { get; set; }

    public bool? Compiled { get; set; }

    public long? Timeteststart { get; set; }

    public string? Compilemessage { get; set; }

    public long? Testsfound { get; set; }

    public bool? Result { get; set; }

    public long? Timeclosed { get; set; }
}
