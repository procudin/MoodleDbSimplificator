using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Nonce used for authentication between moodle and a consumer
/// </summary>
public partial class MdlEnrolLtiLti2Nonce
{
    public long Id { get; set; }

    public long Consumerid { get; set; }

    public string Value { get; set; } = null!;

    public long Expires { get; set; }
}
