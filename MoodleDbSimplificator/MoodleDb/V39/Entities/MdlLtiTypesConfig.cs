using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Basic LTI types configuration
/// </summary>
public partial class MdlLtiTypesConfig
{
    public long Id { get; set; }

    public long Typeid { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
