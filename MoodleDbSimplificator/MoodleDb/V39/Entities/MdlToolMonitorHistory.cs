using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Table to store history of message notifications sent
/// </summary>
public partial class MdlToolMonitorHistory
{
    public long Id { get; set; }

    public long Sid { get; set; }

    public long Userid { get; set; }

    public long Timesent { get; set; }
}
