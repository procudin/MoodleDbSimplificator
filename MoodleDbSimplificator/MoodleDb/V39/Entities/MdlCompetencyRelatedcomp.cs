using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Related competencies
/// </summary>
public partial class MdlCompetencyRelatedcomp
{
    public long Id { get; set; }

    public long Competencyid { get; set; }

    public long Relatedcompetencyid { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long Usermodified { get; set; }
}
