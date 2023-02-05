using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// A service is a group of functions
/// </summary>
public partial class MdlMnetService
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Apiversion { get; set; } = null!;

    public bool Offer { get; set; }
}
