using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlQuestionGradertestTest
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Testin { get; set; }

    public string? Testout { get; set; }

    public long Questionid { get; set; }

    public string? Testdirpath { get; set; }
}
