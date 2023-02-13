using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleDbSimplificator.ExportDb.Entities;

public class Course
{
    public long CourseId { get; set; }
    public string FullName { get; set; } = null!;
    public string ShortName { get; set; } = null!;
    public string Lang { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
