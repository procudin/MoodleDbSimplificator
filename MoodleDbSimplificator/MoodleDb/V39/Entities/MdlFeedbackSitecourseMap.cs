using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// feedback sitecourse map
/// </summary>
public partial class MdlFeedbackSitecourseMap
{
    public long Id { get; set; }

    public long Feedbackid { get; set; }

    public long Courseid { get; set; }
}
