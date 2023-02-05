using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores H5P library dependencies
/// </summary>
public partial class MdlH5pLibraryDependency
{
    public long Id { get; set; }

    public long Libraryid { get; set; }

    public long Requiredlibraryid { get; set; }

    public string Dependencytype { get; set; } = null!;
}
