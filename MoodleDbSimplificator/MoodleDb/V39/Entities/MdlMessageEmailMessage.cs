using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Keeps track of what emails to send in an email digest
/// </summary>
public partial class MdlMessageEmailMessage
{
    public long Id { get; set; }

    public long Useridto { get; set; }

    public long Conversationid { get; set; }

    public long Messageid { get; set; }
}
