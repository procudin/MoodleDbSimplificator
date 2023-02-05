using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Settings for answer plugins
/// </summary>
public partial class MdlPoasassignmentAnsStng
{
    public long Id { get; set; }

    public string? Value { get; set; }

    public string? Name { get; set; }

    public long? Answerid { get; set; }

    public long? Poasassignmentid { get; set; }
}
