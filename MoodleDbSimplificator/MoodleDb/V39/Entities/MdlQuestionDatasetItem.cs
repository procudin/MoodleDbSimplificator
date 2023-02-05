using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Individual dataset items
/// </summary>
public partial class MdlQuestionDatasetItem
{
    public long Id { get; set; }

    public long Definition { get; set; }

    public long Itemnumber { get; set; }

    public string Value { get; set; } = null!;
}
