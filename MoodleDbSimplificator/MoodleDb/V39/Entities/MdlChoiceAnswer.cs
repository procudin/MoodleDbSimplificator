﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// choices performed by users
/// </summary>
public partial class MdlChoiceAnswer
{
    public long Id { get; set; }

    public long Choiceid { get; set; }

    public long Userid { get; set; }

    public long Optionid { get; set; }

    public long Timemodified { get; set; }
}
