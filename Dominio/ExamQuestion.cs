using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio
{
    public class ExamQuestion
    {
        public int id { get; set; }
        public int ExamId { get; set; }
        public Exam? Exam { get; set; }

        public int Order { get; set; }

        public string? QuestionType { get; set; }
        public string? QuestionText { get; set; }
        public string? OptionsJson { get; set; } // JSON array for options if applicable
        public string? CorrectAnswer { get; set; } // JSON array for multiple correct answers if applicable
        public decimal Points { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
    }
}