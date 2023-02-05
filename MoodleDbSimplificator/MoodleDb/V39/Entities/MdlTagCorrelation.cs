using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// The rationale for the &apos;tag_correlation&apos; table is performance
/// </summary>
public partial class MdlTagCorrelation
{
    public long Id { get; set; }

    public long Tagid { get; set; }

    public string Correlatedtags { get; set; } = null!;
}
