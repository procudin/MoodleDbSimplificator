using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// frequently used comments used in marking guide
/// </summary>
public partial class MdlGradingformGuideComment
{
    public long Id { get; set; }

    public long Definitionid { get; set; }

    public long Sortorder { get; set; }

    public string? Description { get; set; }

    public sbyte? Descriptionformat { get; set; }
}
