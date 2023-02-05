using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Test for regex
/// </summary>
public partial class MdlQtypePregRegexTest
{
    public long Id { get; set; }

    public long Answerid { get; set; }

    public string Regextests { get; set; } = null!;
}
