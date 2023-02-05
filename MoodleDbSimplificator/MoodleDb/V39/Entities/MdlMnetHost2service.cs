using System;
using System.Collections.Generic;

namespace MoodleDbSimplificator.MoodleDb.V39.Entities;

/// <summary>
/// Information about the services for a given host
/// </summary>
public partial class MdlMnetHost2service
{
    public long Id { get; set; }

    public long Hostid { get; set; }

    public long Serviceid { get; set; }

    public bool Publish { get; set; }

    public bool Subscribe { get; set; }
}
