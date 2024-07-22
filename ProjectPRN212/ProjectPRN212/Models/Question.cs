using System;
using System.Collections.Generic;

namespace ProjectPRN212.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? Question1 { get; set; }

    public string? Answer1 { get; set; }

    public string? Answer2 { get; set; }

    public string? Answer3 { get; set; }

    public string? Answer4 { get; set; }

    public int? CorrectAnswer { get; set; }

    public string? ImgQuestion { get; set; }

    public int LicenseId { get; set; }

    public virtual TypeOfLicense License { get; set; } = null!;
}
