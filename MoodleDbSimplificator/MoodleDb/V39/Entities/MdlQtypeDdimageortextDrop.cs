using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Drop boxes
/// </summary>
public partial class MdlQtypeDdimageortextDrop
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long No { get; set; }

    public long Xleft { get; set; }

    public long Ytop { get; set; }

    public long Choice { get; set; }

    public string Label { get; set; } = null!;
}
