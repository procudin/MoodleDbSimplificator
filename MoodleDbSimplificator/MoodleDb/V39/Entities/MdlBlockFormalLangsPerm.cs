using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// A permissions for courses and categories to see languages in
/// </summary>
public partial class MdlBlockFormalLangsPerm
{
    public long Id { get; set; }

    public long Languageid { get; set; }

    public long Contextid { get; set; }

    public bool Visible { get; set; }
}
