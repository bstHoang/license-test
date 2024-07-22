using System;
using System.Collections.Generic;

namespace ProjectPRN212.Models;

public partial class TypeOfLicense
{
    public int LicenseId { get; set; }

    public string? LicenseName { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
