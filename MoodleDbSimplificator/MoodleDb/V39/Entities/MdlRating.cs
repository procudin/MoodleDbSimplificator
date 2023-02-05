using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// moodle ratings
/// </summary>
public partial class MdlRating
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string Component { get; set; } = null!;

    public string Ratingarea { get; set; } = null!;

    public long Itemid { get; set; }

    public long Scaleid { get; set; }

    public long Rating { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
