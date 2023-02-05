using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment
/// </summary>
public partial class MdlBlockSupervisedLessontype
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Courseid { get; set; }
}
