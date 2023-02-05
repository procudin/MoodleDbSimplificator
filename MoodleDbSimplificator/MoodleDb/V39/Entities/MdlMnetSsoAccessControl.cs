using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Users by host permitted (or not) to login from a remote prov
/// </summary>
public partial class MdlMnetSsoAccessControl
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public long MnetHostId { get; set; }

    public string Accessctrl { get; set; } = null!;
}
