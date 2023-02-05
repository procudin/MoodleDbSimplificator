using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// To store every course backup status
/// </summary>
public partial class MdlBackupCourse
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Laststarttime { get; set; }

    public long Lastendtime { get; set; }

    public string Laststatus { get; set; } = null!;

    public long Nextstarttime { get; set; }
}
