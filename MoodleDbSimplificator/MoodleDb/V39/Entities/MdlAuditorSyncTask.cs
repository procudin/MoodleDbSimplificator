using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for auditor_sync, please edit me
/// </summary>
public partial class MdlAuditorSyncTask
{
    public long Id { get; set; }

    public long Auditorvariantid { get; set; }

    public long Poasassignmenttaskid { get; set; }

    public string? Comments { get; set; }
}
