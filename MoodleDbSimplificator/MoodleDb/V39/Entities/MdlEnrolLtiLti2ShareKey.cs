using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Resource link share key
/// </summary>
public partial class MdlEnrolLtiLti2ShareKey
{
    public long Id { get; set; }

    public string Sharekey { get; set; } = null!;

    public long Resourcelinkid { get; set; }

    public bool Autoapprove { get; set; }

    public long Expires { get; set; }
}
