using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Security tokens for accessing of LTI services
/// </summary>
public partial class MdlLtiAccessToken
{
    public long Id { get; set; }

    public long Typeid { get; set; }

    public string Scope { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long Validuntil { get; set; }

    public long Timecreated { get; set; }

    public long? Lastaccess { get; set; }
}
