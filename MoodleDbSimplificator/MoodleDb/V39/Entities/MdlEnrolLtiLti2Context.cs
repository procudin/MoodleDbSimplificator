using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Information about a specific LTI contexts from the consumers
/// </summary>
public partial class MdlEnrolLtiLti2Context
{
    public long Id { get; set; }

    public long Consumerid { get; set; }

    public string Lticontextkey { get; set; } = null!;

    public string? Type { get; set; }

    public string? Settings { get; set; }

    public long Created { get; set; }

    public long Updated { get; set; }
}
