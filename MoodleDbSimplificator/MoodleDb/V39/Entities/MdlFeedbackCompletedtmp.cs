﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// filled out feedback
/// </summary>
public partial class MdlFeedbackCompletedtmp
{
    public long Id { get; set; }

    public long Feedback { get; set; }

    public long Userid { get; set; }

    public string Guestid { get; set; } = null!;

    public long Timemodified { get; set; }

    public long RandomResponse { get; set; }

    public bool AnonymousResponse { get; set; }

    public long Courseid { get; set; }
}
