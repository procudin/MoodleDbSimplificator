using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Maintains list of contact requests between users
/// </summary>
public partial class MdlMessageContactRequest
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Requesteduserid { get; set; }

    public long Timecreated { get; set; }
}
