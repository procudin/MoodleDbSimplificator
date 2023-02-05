using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Values of poasassignment fields
/// </summary>
public partial class MdlPoasassignmentTaskValue
{
    public long Id { get; set; }

    public long? Taskid { get; set; }

    public long? Fieldid { get; set; }

    public string? Value { get; set; }

    public long? Assigneeid { get; set; }

    public sbyte? Valueformat { get; set; }
}
