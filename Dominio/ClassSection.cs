using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClassSection
    {
        public int Id { get; set; }

        public int gradeId { get; set; }
        public Grade? grade { get; set; }
        public string? Name { get; set; }
        public int HomeroomTeacherId { get; set; }
        public Teacher? HomeroomTeacher { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<CourseSchedule>? Schedules { get; set; }
        public ICollection<AttendanceSession>? AttendanceSessions { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }
}