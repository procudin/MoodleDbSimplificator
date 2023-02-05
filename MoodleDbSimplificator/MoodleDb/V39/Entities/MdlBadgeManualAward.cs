using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Track manual award criteria for badges
/// </summary>
public partial class MdlBadgeManualAward
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public long Recipientid { get; set; }

    public long Issuerid { get; set; }

    public long Issuerrole { get; set; }

    public long Datemet { get; set; }
}
