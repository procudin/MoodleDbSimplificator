using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines criteria for issuing badges
/// </summary>
public partial class MdlBadgeCriterion
{
    public long Id { get; set; }

    public long Badgeid { get; set; }

    public long? Criteriatype { get; set; }

    public bool? Method { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }
}
