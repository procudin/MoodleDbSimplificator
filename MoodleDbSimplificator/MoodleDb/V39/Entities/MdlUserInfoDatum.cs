﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Data for the customisable user fields
/// </summary>
public partial class MdlUserInfoDatum
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Fieldid { get; set; }

    public string Data { get; set; } = null!;

    public sbyte Dataformat { get; set; }
}
