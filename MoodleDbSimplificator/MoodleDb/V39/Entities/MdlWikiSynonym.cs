using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores wiki pages synonyms
/// </summary>
public partial class MdlWikiSynonym
{
    public long Id { get; set; }

    public long Subwikiid { get; set; }

    public long Pageid { get; set; }

    public string Pagesynonym { get; set; } = null!;
}
