using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class CourseSchedule
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int ClassSectionId { get; set; }
        public ClassSection? ClassSection { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }

        public string? RecurrenceType { get; set; } // Daily, Weekly, Monthly

        public string? DaysOfWeek { get; set; } // Comma-separated days for weekly recurrence (e.g., "Monday,Wednesday,Friday")
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; } // Optional end date for the schedule

        public string? TimeZoneId { get; set; } // Time zone identifier (e.g., "America/New_York")
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<CourseScheduleException> Exceptions { get; set; } = new List<CourseScheduleException>();
    }
}