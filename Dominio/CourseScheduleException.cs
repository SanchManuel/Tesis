using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class CourseScheduleException
    {
        public int Id { get; set; }
        public int CourseScheduleId { get; set; }
        public CourseSchedule? CourseSchedule { get; set; }
        public DateOnly OcurrenceDate { get; set; }
        public string? ScheduleExceptionTYpe { get; set; } // Cancellation, Reschedule

        public TimeOnly? NewStartTime { get; set; } // New start time for rescheduled occurrences
        public TimeOnly? NewEndTime { get; set; } // New end time for

        public int? NewClassroomId { get; set; } // Optional new classroom for rescheduled occurrences
        public Classroom? NewClassroom { get; set; }
        public string? Reason { get; set; } // Reason for the exception
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}