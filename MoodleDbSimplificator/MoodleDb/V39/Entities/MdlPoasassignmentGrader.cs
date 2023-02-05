using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Table of installed graders
/// </summary>
public partial class MdlPoasassignmentGrader
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }
}
