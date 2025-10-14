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
        public string? FileName { get; set; }
        public string? StorageUrl { get; set; }
        public string? ContentType { get; set; }
        public long? SizeBytes { get; set; }
        public DateTime UploadedAt { get; set; }
        public AssignmentSubmission? AssignmentSubmission { get; set; }

    }
}