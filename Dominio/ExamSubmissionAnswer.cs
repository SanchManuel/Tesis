using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dominio
{
    public class ExamSubmissionAnswer
    {
        public int id { get; set; }
        public int ExamSubmissionId { get; set; }
        public ExamSubmission? ExamSubmission { get; set; }
        public int ExamQuestionId { get; set; }
        public ExamQuestion? ExamQuestion { get; set; }

        public string? AnswerText { get; set; } // JSON array for multiple answers if applicable
        public bool? IsCorrect { get; set; }
        public decimal Score { get; set; }
    }
}