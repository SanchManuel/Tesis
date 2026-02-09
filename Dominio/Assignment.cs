using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Assignment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Instructions { get; set; }

        public string? AssignmentType { get; set; } // e.g., Homework, Quiz, Project
        public string? AssignmentStatus { get; set; } // e.g., Pending, Completed, Graded

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public int classSectionId { get; set; }
        public ClassSection? ClassSection { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public string? SubmissionType { get; set; } // e.g., Online, In-Person
        public string? GradingType { get; set; } // e.g., Automatic, Manual
        public decimal? MaxPoints { get; set; }
        public bool IsGroupWork { get; set; } = false;

        public DateTime PublishAt { get; set; } = DateTime.UtcNow;
        public DateTime DueAt { get; set; }
        public DateTime? ClosedAt { get; set; }

        public bool AllowsLateSubmissions { get; set; } = false;
        public decimal? LatePenaltyPerDay { get; set; } // e.g., 10

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

    }
}