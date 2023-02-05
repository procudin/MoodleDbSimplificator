using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Map an assignment specific id number to a user
/// </summary>
public partial class MdlAssignUserMapping
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Userid { get; set; }
}
