using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// The assessment dimensions definitions of Comments strategy f
/// </summary>
public partial class MdlWorkshopformComment
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public long? Sort { get; set; }

    public string? Description { get; set; }

    public short? Descriptionformat { get; set; }
}
