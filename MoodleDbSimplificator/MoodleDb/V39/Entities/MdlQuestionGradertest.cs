using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlQuestionGradertest
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public bool? Availablefromhome { get; set; }
}
