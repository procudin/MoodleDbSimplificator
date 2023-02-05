using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines poasassignments
/// </summary>
public partial class MdlPoasassignment
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long Timemodified { get; set; }

    public long Availabledate { get; set; }

    public long Choicedate { get; set; }

    public long Deadline { get; set; }

    public long Flags { get; set; }

    public long Taskgiverid { get; set; }

    public bool Uniqueness { get; set; }

    public decimal? Penalty { get; set; }

    public long Grade { get; set; }
}
