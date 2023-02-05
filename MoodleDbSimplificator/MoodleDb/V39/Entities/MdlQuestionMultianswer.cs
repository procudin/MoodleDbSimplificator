using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Options for multianswer questions
/// </summary>
public partial class MdlQuestionMultianswer
{
    public long Id { get; set; }

    public long Question { get; set; }

    public string Sequence { get; set; } = null!;
}
