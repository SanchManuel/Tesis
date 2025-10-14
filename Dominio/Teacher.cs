using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Teacher
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public User? user { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Rfc { get; set; }
        public string? Curp { get; set; }
        public string? Photo { get; set; }
        public int yearsOfExperience { get; set; }
        public string? specialty { get; set; }
        public string? Position { get; set; }
        public int departmentId { get; set; }
        public Department? department { get; set; }
        public DateTime? HireDate { get; set; }
        public string? EmploymentType { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Assignment>? CreatedAssignments { get; set; }
        public ICollection<CourseSchedule>? Schedules { get; set; }
        public ICollection<AttendanceSession>? AttendanceSessions { get; set; }
        public ICollection<Exam>? Exams { get; set; }
        public ICollection<ExtracurricularActivity>? ExtracurricularActivities { get; set; }
    }
}