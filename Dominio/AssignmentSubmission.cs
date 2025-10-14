using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AssignmentSubmission
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public string? OnlineText { get; set; }
        public string? Url { get; set; }
        public string? FileStorageUrl { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public long? SizeBytes { get; set; }
        public DateTime SubmittedAt { get; set; }
        public bool IsLate { get; set; }
        public decimal? Score { get; set; }
        public bool? Passed { get; set; }
        public string? Feedback { get; set; }
        public DateTime? GradedAt { get; set; }
        public int GradedByTecherId { get; set; }
        public Assignment? Assignment { get; set; }
        public Student? Student { get; set; }
        public Teacher? GradedByTeacher { get; set; }
        public ICollection<SubmissionFile> Files { get; set; } = new List<SubmissionFile>();
    }
}