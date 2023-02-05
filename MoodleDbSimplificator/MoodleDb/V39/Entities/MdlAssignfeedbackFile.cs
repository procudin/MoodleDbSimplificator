using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores info about the number of files submitted by a student
/// </summary>
public partial class MdlAssignfeedbackFile
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Grade { get; set; }

    public long Numfiles { get; set; }
}
