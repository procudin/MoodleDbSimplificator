using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// An information about symbols, that emerge from lexical and s
/// </summary>
public partial class MdlBlockFormalLangsNodeDscr
{
    public long Id { get; set; }

    public string Tablename { get; set; } = null!;

    public long Tableid { get; set; }

    public long Number { get; set; }

    public string Description { get; set; } = null!;
}
