using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// A word forms for producing descriptions
/// </summary>
public partial class MdlBlockFormalLangsWordFrm
{
    public long Id { get; set; }

    public string Language { get; set; } = null!;

    public string Formname { get; set; } = null!;

    public string Originalform { get; set; } = null!;

    public string Form { get; set; } = null!;
}
