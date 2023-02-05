using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// H5P cached library assets
/// </summary>
public partial class MdlH5pLibrariesCachedasset
{
    public long Id { get; set; }

    public long Libraryid { get; set; }

    public string Hash { get; set; } = null!;
}
