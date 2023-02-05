using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// An language descriptions
/// </summary>
public partial class MdlBlockFormalLang
{
    public long Id { get; set; }

    public string Uiname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Name { get; set; }

    public string? Scanrules { get; set; }

    public string? Parserules { get; set; }

    public string Version { get; set; } = null!;

    public short Visible { get; set; }

    public string? Lexemname { get; set; }

    public long Author { get; set; }
}
