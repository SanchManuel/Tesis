using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class StudentGrade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public int classSectionId { get; set; }
        public ClassSection? classSection { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public string? AssignmentName { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Score { get; set; }
        public decimal? MaxScore { get; set; }
        public string? Letter { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

    }
}