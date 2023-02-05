﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// This table keeps information about gradeable items (ie colum
/// </summary>
public partial class MdlGradeItem
{
    public long Id { get; set; }

    public long? Courseid { get; set; }

    public long? Categoryid { get; set; }

    public string? Itemname { get; set; }

    public string Itemtype { get; set; } = null!;

    public string? Itemmodule { get; set; }

    public long? Iteminstance { get; set; }

    public long? Itemnumber { get; set; }

    public string? Iteminfo { get; set; }

    public string? Idnumber { get; set; }

    public string? Calculation { get; set; }

    public short Gradetype { get; set; }

    public decimal Grademax { get; set; }

    public decimal Grademin { get; set; }

    public long? Scaleid { get; set; }

    public long? Outcomeid { get; set; }

    public decimal Gradepass { get; set; }

    public decimal Multfactor { get; set; }

    public decimal Plusfactor { get; set; }

    public decimal Aggregationcoef { get; set; }

    public decimal Aggregationcoef2 { get; set; }

    public long Sortorder { get; set; }

    public long Display { get; set; }

    public bool? Decimals { get; set; }

    public long Hidden { get; set; }

    public long Locked { get; set; }

    public long Locktime { get; set; }

    public long Needsupdate { get; set; }

    public bool Weightoverride { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }
}
