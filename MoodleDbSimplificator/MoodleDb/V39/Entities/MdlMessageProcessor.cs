using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// List of message output plugins
/// </summary>
public partial class MdlMessageProcessor
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Enabled { get; set; }
}
