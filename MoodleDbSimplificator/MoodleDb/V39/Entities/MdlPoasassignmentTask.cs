using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlPoasassignmentTask
{
    public long Id { get; set; }

    public long? Poasassignmentid { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? Deadline { get; set; }

    public bool? Hidden { get; set; }

    public string? Descriptionformat { get; set; }
}
