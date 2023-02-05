﻿using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores active and inactive lock types for db locking method.
/// </summary>
public partial class MdlLockDb
{
    public long Id { get; set; }

    public string Resourcekey { get; set; } = null!;

    public long? Expires { get; set; }

    public string? Owner { get; set; }
}
