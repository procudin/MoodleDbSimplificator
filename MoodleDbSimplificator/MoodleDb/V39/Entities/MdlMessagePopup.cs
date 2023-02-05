using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Keep state of notifications for the popup message processor
/// </summary>
public partial class MdlMessagePopup
{
    public long Id { get; set; }

    public long Messageid { get; set; }

    public bool Isread { get; set; }
}
