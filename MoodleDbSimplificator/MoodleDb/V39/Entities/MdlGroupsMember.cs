using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Link a user to a group.
/// </summary>
public partial class MdlGroupsMember
{
    public long Id { get; set; }

    public long Groupid { get; set; }

    public long Userid { get; set; }

    public long Timeadded { get; set; }

    public string Component { get; set; } = null!;

    public long Itemid { get; set; }
}
