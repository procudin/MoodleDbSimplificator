using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Link a competency to a learning plan template.
/// </summary>
public partial class MdlCompetencyTemplatecomp
{
    public long Id { get; set; }

    public long Templateid { get; set; }

    public long Competencyid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long? Sortorder { get; set; }
}
