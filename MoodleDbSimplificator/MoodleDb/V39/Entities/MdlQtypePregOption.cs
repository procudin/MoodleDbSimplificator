using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Options for perl-compatible regular expression questions
/// </summary>
public partial class MdlQtypePregOption
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public string Answers { get; set; } = null!;

    public sbyte Usecase { get; set; }

    public string Correctanswer { get; set; } = null!;

    public sbyte Exactmatch { get; set; }

    public sbyte Approximatematch { get; set; }

    public long Maxtypos { get; set; }

    public float Typospenalty { get; set; }

    public sbyte Usecharhint { get; set; }

    public float Charhintpenalty { get; set; }

    public float Hintgradeborder { get; set; }

    public string Engine { get; set; } = null!;

    public string Notation { get; set; } = null!;

    public sbyte Uselexemhint { get; set; }

    public float Lexemhintpenalty { get; set; }

    public sbyte Usehowtofixpichint { get; set; }

    public float Howtofixpichintpenalty { get; set; }

    public long Langid { get; set; }

    public string Lexemusername { get; set; } = null!;
}
