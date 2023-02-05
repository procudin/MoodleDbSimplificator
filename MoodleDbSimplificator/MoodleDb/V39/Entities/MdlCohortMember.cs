using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Link a user to a cohort.
/// </summary>
public partial class MdlCohortMember
{
    public long Id { get; set; }

    public long Cohortid { get; set; }

    public long Userid { get; set; }

    public long Timeadded { get; set; }
}
