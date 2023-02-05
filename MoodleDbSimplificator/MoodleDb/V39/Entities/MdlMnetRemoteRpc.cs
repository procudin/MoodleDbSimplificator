using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// This table describes functions that might be called remotely
/// </summary>
public partial class MdlMnetRemoteRpc
{
    public long Id { get; set; }

    public string Functionname { get; set; } = null!;

    public string Xmlrpcpath { get; set; } = null!;

    public string Plugintype { get; set; } = null!;

    public string Pluginname { get; set; } = null!;

    public bool Enabled { get; set; }
}
