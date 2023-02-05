using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Defines settings for site level backpacks that a user can co
/// </summary>
public partial class MdlBadgeExternalBackpack
{
    public long Id { get; set; }

    public string Backpackapiurl { get; set; } = null!;

    public string Backpackweburl { get; set; } = null!;

    public string Apiversion { get; set; } = null!;

    public long Sortorder { get; set; }

    public string? Password { get; set; }

    public long? Oauth2Issuerid { get; set; }
}
