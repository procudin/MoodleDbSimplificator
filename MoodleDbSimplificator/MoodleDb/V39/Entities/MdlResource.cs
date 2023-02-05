﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Each record is one resource and its config data
/// </summary>
public partial class MdlResource
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public short Tobemigrated { get; set; }

    public short Legacyfiles { get; set; }

    public long? Legacyfileslast { get; set; }

    public short Display { get; set; }

    public string? Displayoptions { get; set; }

    public short Filterfiles { get; set; }

    public long Revision { get; set; }

    public long Timemodified { get; set; }
}
