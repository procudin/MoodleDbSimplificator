using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// core_customfield category table
/// </summary>
public partial class MdlCustomfieldCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long? Descriptionformat { get; set; }

    public long? Sortorder { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Component { get; set; } = null!;

    public string Area { get; set; } = null!;

    public long Itemid { get; set; }

    public long? Contextid { get; set; }
}
