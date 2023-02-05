using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// This table stores which which other roles a user is allowed 
/// </summary>
public partial class MdlRoleAllowView
{
    public long Id { get; set; }

    public long Roleid { get; set; }

    public long Allowview { get; set; }
}
