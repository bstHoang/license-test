using System;
using System.Collections.Generic;

namespace ProjectPRN212.Models;

public partial class User
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<ExamHistory> ExamHistories { get; set; } = new List<ExamHistory>();

    public virtual Role? Role { get; set; }
}
