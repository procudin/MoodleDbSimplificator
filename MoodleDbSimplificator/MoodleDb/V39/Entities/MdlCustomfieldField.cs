using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// core_customfield field table
/// </summary>
public partial class MdlCustomfieldField
{
    public long Id { get; set; }

    public string Shortname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public long? Descriptionformat { get; set; }

    public long? Sortorder { get; set; }

    public long? Categoryid { get; set; }

    public string? Configdata { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
