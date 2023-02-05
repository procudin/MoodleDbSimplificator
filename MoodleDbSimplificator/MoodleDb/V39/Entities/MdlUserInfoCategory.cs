using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Customisable fields categories
/// </summary>
public partial class MdlUserInfoCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Sortorder { get; set; }
}
