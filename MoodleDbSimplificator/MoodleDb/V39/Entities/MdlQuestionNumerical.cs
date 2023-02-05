using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Options for numerical questions.
/// </summary>
public partial class MdlQuestionNumerical
{
    public long Id { get; set; }

    public long Question { get; set; }

    public long Answer { get; set; }

    public string Tolerance { get; set; } = null!;
}
