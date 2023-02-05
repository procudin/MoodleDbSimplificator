using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// branches for each lesson/user
/// </summary>
public partial class MdlLessonBranch
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Userid { get; set; }

    public long Pageid { get; set; }

    public long Retry { get; set; }

    public short Flag { get; set; }

    public long Timeseen { get; set; }

    public long Nextpageid { get; set; }
}
