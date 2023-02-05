using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Results for each user for each resource link
/// </summary>
public partial class MdlEnrolLtiLti2UserResult
{
    public long Id { get; set; }

    public long Resourcelinkid { get; set; }

    public string Ltiuserkey { get; set; } = null!;

    public string Ltiresultsourcedid { get; set; } = null!;

    public long Created { get; set; }

    public long Updated { get; set; }
}
