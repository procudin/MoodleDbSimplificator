using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// A list of items in the category recycle bin
/// </summary>
public partial class MdlToolRecyclebinCategory
{
    public long Id { get; set; }

    public long Categoryid { get; set; }

    public string Shortname { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public long Timecreated { get; set; }
}
