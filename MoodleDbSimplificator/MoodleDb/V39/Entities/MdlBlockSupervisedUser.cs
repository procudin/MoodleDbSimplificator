using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Users in session
/// </summary>
public partial class MdlBlockSupervisedUser
{
    public long Id { get; set; }

    public long Sessionid { get; set; }

    public long Userid { get; set; }
}
