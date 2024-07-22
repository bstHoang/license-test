using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN212.Models
{
    public class CorrectAnswer
    {
        public int AnswerNumber { get; set; }
        public string AnswerText { get; set; }

        public CorrectAnswer(int answerNumber, string answerText)
        {
            AnswerNumber = answerNumber;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}
