using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// config for portfolio plugin instances
/// </summary>
public partial class MdlPortfolioInstanceConfig
{
    public long Id { get; set; }

    public long Instance { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
