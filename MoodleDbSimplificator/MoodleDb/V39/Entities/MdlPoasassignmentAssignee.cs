using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Connects Moodle user with poasassignment task and attempts
/// </summary>
public partial class MdlPoasassignmentAssignee
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public long Timetaken { get; set; }

    public long? Poasassignmentid { get; set; }

    public long Taskid { get; set; }

    public long? Finalized { get; set; }

    public bool Cancelled { get; set; }
}
