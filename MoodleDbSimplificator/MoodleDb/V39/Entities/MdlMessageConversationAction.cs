using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Stores all per-user actions on individual conversations
/// </summary>
public partial class MdlMessageConversationAction
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Conversationid { get; set; }

    public long Action { get; set; }

    public long Timecreated { get; set; }
}
