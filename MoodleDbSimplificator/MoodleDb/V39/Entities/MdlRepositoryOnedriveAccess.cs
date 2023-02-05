using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// List of temporary access grants.
/// </summary>
public partial class MdlRepositoryOnedriveAccess
{
    public long Id { get; set; }

    public long Timemodified { get; set; }

    public long Timecreated { get; set; }

    public long Usermodified { get; set; }

    public string Permissionid { get; set; } = null!;

    public string Itemid { get; set; } = null!;
}
