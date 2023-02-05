using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Tracks each users untracked forums
/// </summary>
public partial class MdlForumTrackPref
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forumid { get; set; }
}
