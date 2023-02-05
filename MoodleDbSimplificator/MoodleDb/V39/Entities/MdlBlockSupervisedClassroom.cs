using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment
/// </summary>
public partial class MdlBlockSupervisedClassroom
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Iplist { get; set; } = null!;

    public bool? Active { get; set; }
}
