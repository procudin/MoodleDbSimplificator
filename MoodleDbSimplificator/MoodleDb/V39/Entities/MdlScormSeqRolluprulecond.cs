﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// SCORM2004 sequencing rule
/// </summary>
public partial class MdlScormSeqRolluprulecond
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public long Rollupruleid { get; set; }

    public string Operator { get; set; } = null!;

    public string Cond { get; set; } = null!;
}
