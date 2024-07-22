using System;
using System.Collections.Generic;

namespace ProjectPRN212.Models;

public partial class ListQuestion
{
    public int QuestionId { get; set; }

    public int? YourAnser { get; set; }

    public int ExamHistoryId { get; set; }
    public int ListQuestion_Id { get; set; }
    public virtual ExamHistory ExamHistory { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
