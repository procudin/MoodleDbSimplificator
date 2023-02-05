using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlPoasassignmentGrRaTest
{
    public long Id { get; set; }

    public long? RemoteId { get; set; }

    public string? Test { get; set; }

    public long? Timetested { get; set; }

    public string? Testin { get; set; }

    public string? Testout { get; set; }

    public string? Studentout { get; set; }

    public bool? Testpassed { get; set; }
}
