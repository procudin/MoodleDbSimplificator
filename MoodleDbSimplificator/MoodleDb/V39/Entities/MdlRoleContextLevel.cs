using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Lists which roles can be assigned at which context levels. T
/// </summary>
public partial class MdlRoleContextLevel
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Contextlevel { get; set; }
}
