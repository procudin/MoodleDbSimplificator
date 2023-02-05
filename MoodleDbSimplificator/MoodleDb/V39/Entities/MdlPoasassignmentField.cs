using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Fileds for poasassignment individual tasks
/// </summary>
public partial class MdlPoasassignmentField
{
    public long Id { get; set; }

    public long? Poasassignmentid { get; set; }

    public long? Ftype { get; set; }

    public string? Name { get; set; }

    public bool? Showintable { get; set; }

    public decimal? Valuemax { get; set; }

    public decimal? Valuemin { get; set; }

    public bool? Secretfield { get; set; }

    public bool? Random { get; set; }

    public string? Description { get; set; }
}
