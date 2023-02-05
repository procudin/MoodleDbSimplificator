using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// This table contains main options for CorrectWriting question
/// </summary>
public partial class MdlQtypeCorrectwriting
{
    public long Id { get; set; }

    public long Questionid { get; set; }

    public long Langid { get; set; }

    public decimal Absentmistakeweight { get; set; }

    public decimal? Addedmistakeweight { get; set; }

    public decimal Movedmistakeweight { get; set; }

    public decimal Lexicalerrorthreshold { get; set; }

    public decimal Lexicalerrorweight { get; set; }

    public short Usecase { get; set; }

    public decimal Hintgradeborder { get; set; }

    public decimal Maxmistakepercentage { get; set; }

    public decimal Whatishintpenalty { get; set; }

    public decimal Wheretxthintpenalty { get; set; }

    public decimal Absenthintpenaltyfactor { get; set; }

    public decimal Wherepichintpenalty { get; set; }

    public short Islexicalanalyzerenabled { get; set; }

    public short Isenumanalyzerenabled { get; set; }

    public short Issequenceanalyzerenabled { get; set; }

    public short Issyntaxanalyzerenabled { get; set; }

    public decimal Howtofixpichintpenalty { get; set; }

    public short Allowinvalidsyntaxanswers { get; set; }
}
