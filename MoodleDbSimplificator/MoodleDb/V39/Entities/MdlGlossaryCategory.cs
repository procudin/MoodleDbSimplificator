using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// all categories for glossary entries
/// </summary>
public partial class MdlGlossaryCategory
{
    public long Id { get; set; }

    public long Glossaryid { get; set; }

    public string Name { get; set; } = null!;

    public sbyte Usedynalink { get; set; }
}
