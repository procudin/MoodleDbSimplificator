using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Optional unit options for numerical questions. This table is
/// </summary>
public partial class MdlQuestionNumericalUnit
{
    public long Id { get; set; }

    public long Question { get; set; }

    public decimal Multiplier { get; set; }

    public string Unit { get; set; } = null!;
}
