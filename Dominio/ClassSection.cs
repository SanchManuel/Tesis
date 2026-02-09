using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClassSection
    {
        public int Id { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public string? Name { get; set; }
        public int HomeroomTeacherId { get; set; }
        public Teacher? HomeroomTeacher { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<CourseSchedule>? Schedules { get; set; }
        public ICollection<AttendanceSession>? AttendanceSessions { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }
}