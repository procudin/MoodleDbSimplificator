using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// available options to choice
/// </summary>
public partial class MdlChoiceOption
{
    public long Id { get; set; }

    public long Choiceid { get; set; }

    public string? Text { get; set; }

    public long? Maxanswers { get; set; }

    public long Timemodified { get; set; }
}
