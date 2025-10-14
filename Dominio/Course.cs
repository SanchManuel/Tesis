using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public int GradeId { get; set; }
        public Grade? Grade { get; set; }
        public int ClassSectionId { get; set; }
        public ClassSection? ClassSection { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int WeeklyHours { get; set; }
        public decimal? Credits { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
        public ICollection<CourseSchedule> Schedules { get; set; } = new List<CourseSchedule>();
        public ICollection<AttendanceSession>? AttendanceSessions { get; set; }
        public ICollection<Exam>? Exams { get; set; }

    }
}