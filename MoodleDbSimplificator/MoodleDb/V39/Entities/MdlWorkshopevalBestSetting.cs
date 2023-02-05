using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Settings for the grading evaluation subplugin Comparison wit
/// </summary>
public partial class MdlWorkshopevalBestSetting
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public short? Comparison { get; set; }
}
