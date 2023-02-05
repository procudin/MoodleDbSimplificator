using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Keeps track of who is subscribed to what forum
/// </summary>
public partial class MdlForumSubscription
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forum { get; set; }
}
