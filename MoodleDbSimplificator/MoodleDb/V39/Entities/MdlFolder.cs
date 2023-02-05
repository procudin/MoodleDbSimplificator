using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// each record is one folder resource
/// </summary>
public partial class MdlFolder
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long Revision { get; set; }

    public long Timemodified { get; set; }

    public short Display { get; set; }

    public bool? Showexpanded { get; set; }

    public bool? Showdownloadfolder { get; set; }
}
