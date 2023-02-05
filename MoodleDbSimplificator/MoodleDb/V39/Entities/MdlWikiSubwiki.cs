using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores subwiki instances
/// </summary>
public partial class MdlWikiSubwiki
{
    public long Id { get; set; }

    public long Wikiid { get; set; }

    public long Groupid { get; set; }

    public long Userid { get; set; }
}
