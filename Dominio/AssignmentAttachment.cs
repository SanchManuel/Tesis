using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AssignmentAttachment
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }

        public string? FileName { get; set; }
        public string? ContentType { get; set; } = "application/octet-stream";

        public long SizeBytes { get; set; }
        public string? StorageUrl { get; set; } // URL or path to the stored file
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}