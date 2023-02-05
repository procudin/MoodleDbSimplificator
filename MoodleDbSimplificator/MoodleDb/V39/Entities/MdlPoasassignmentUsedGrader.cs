using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Connects grader with poasassignment instances
/// </summary>
public partial class MdlPoasassignmentUsedGrader
{
    public long Id { get; set; }

    public long? Poasassignmentid { get; set; }

    public long? Graderid { get; set; }
}
