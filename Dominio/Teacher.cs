using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Teacher
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Rfc { get; set; }
        public string? Curp { get; set; }
        public string? Photo { get; set; }
        public int YearsOfExperience { get; set; }
        public string? Specialty { get; set; }
        public string? Position { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
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