using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Exam
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int classSectionId { get; set; }
        public ClassSection? classSection { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ExamType { get; set; }
        public string? ExamMode { get; set; }
        public string? ExamStatus { get; set; }

        public decimal MaxScore { get; set; }
        public int DurationInMinutes { get; set; }
        public bool AllowLateSubmission { get; set; }

        public DateTime ScheduledAt { get; set; }
        public DateTime OpenAt { get; set; }
        public DateTime CloseAt { get; set; }

        public ICollection<ExamQuestion>? Questions { get; set; }

        public ICollection<ExamSubmission>? Submissions { get; set; }

        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }

    }
}