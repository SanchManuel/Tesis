using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class SubmissionFile
    {
        public int Id { get; set; }
        public int AssignmentSubmissionId { get; set; }
        public string? FileName { get; set; } = null!;
        public string? StorageUrl { get; set; } = null!;
        public string? ContentType { get; set; } = "application/octet-stream";
        public long? SizeBytes { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public AssignmentSubmission? AssignmentSubmission { get; set; }

    }
}