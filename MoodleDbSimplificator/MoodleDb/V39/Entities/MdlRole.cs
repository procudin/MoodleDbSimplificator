using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// moodle roles
/// </summary>
public partial class MdlRole
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Shortname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long Sortorder { get; set; }

    public string Archetype { get; set; } = null!;
}
