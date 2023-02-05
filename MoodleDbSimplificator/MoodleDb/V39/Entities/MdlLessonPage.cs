using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines lesson_pages
/// </summary>
public partial class MdlLessonPage
{
    public long Id { get; set; }

    public long Lessonid { get; set; }

    public long Prevpageid { get; set; }

    public long Nextpageid { get; set; }

    public short Qtype { get; set; }

    public short Qoption { get; set; }

    public short Layout { get; set; }

    public short Display { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Title { get; set; } = null!;

    public string Contents { get; set; } = null!;

    public sbyte Contentsformat { get; set; }
}
