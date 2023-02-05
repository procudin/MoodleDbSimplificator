using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Mapping of oauth user fields to moodle fields.
/// </summary>
public partial class MdlOauth2UserFieldMapping
{
    public long Id { get; set; }

    public long Timemodified { get; set; }

    public long Timecreated { get; set; }

    public long Usermodified { get; set; }

    public long Issuerid { get; set; }

    public string Externalfield { get; set; } = null!;

    public string Internalfield { get; set; } = null!;
}
