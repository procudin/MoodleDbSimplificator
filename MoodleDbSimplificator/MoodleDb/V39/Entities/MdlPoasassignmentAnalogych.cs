using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Table for Analogy choice
/// </summary>
public partial class MdlPoasassignmentAnalogych
{
    public long Id { get; set; }

    public long Originalid { get; set; }

    public long Additionalid { get; set; }
}
