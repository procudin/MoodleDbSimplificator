using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Store which library is used in which content.
/// </summary>
public partial class MdlH5pContentsLibrary
{
    public long Id { get; set; }

    public long H5pid { get; set; }

    public long Libraryid { get; set; }

    public string Dependencytype { get; set; } = null!;

    public bool Dropcss { get; set; }

    public long Weight { get; set; }
}
