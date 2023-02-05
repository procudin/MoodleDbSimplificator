using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// A tool proxy between moodle and a consumer
/// </summary>
public partial class MdlEnrolLtiLti2ToolProxy
{
    public long Id { get; set; }

    public string Toolproxykey { get; set; } = null!;

    public long Consumerid { get; set; }

    public string Toolproxy { get; set; } = null!;

    public long Created { get; set; }

    public long Updated { get; set; }
}
