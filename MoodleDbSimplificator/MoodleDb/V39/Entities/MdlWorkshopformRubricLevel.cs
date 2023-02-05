﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// The definition of rubric rating scales
/// </summary>
public partial class MdlWorkshopformRubricLevel
{
    public long Id { get; set; }

    public long Dimensionid { get; set; }

    public decimal Grade { get; set; }

    public string? Definition { get; set; }

    public short? Definitionformat { get; set; }
}
