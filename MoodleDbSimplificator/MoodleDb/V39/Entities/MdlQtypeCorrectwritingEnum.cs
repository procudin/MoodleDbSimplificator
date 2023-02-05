using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Options for creating enumerations
/// </summary>
public partial class MdlQtypeCorrectwritingEnum
{
    public long Id { get; set; }

    public long Answerid { get; set; }

    public string Enumerations { get; set; } = null!;
}
