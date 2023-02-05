﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Text feedback for submitted assignments
/// </summary>
public partial class MdlAssignfeedbackComment
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Grade { get; set; }

    public string? Commenttext { get; set; }

    public short Commentformat { get; set; }
}
