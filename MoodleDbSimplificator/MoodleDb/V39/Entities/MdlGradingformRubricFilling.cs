using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores the data of how the rubric is filled by a particular 
/// </summary>
public partial class MdlGradingformRubricFilling
{
    public long Id { get; set; }

    public long Instanceid { get; set; }

    public long Criterionid { get; set; }

    public long? Levelid { get; set; }

    public string? Remark { get; set; }

    public sbyte? Remarkformat { get; set; }
}
