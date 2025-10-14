using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExtracurricularActivity
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; } // e.g., "Sports", "Arts", "Science Club"
        public string? Status { get; set; } // e.g., "Active", "Inactive"

        public int TeacherId { get; set; }
        public User? Teacher { get; set; }

        public int StaffId { get; set; }

        public User? Staff { get; set; }

        public string? DaysOfWeek { get; set; } // e.g., "Monday,Wednesday,Friday"
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public string? Location { get; set; } // e.g., "Gym", "

        public int Capacity { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }

        // Relaciones
        public ICollection<ActivityEnrollment>? Enrollments { get; set; }

        // Auditoría
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
    }
}