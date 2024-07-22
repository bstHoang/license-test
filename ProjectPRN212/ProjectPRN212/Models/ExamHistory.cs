using System;
using System.Collections.Generic;

namespace ProjectPRN212.Models;

public partial class ExamHistory
{
    public int? UserId { get; set; }

    public double? Score { get; set; }

    public DateTime? ExamTime { get; set; }

    public int ExamHistoryId { get; set; }

    public virtual User? User { get; set; }
}
