using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExamSubmission
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public int ExamId { get; set; }
        public Exam? Exam { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public DateTime? StartedAt { get; set; }
        public DateTime? SubmittedAtUtc { get; set; }

        public bool IsLate { get; set; }
        public decimal Score { get; set; }
        public string? Feedback { get; set; }

        public ICollection<ExamSubmissionAnswer>? Answers { get; set; }


    }
}