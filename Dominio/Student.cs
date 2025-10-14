using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Student
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? NationalId { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? GuardianName { get; set; }
        public string? GuardianPhone { get; set; }
        public string? GuardianEmail { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }

        public DateTime EnrollmentDate { get; set; }
        private string? EnrollmentStatus { get; set; }
        public bool IsActive { get; set; } = true;



        public ICollection<AttendanceRecord>? AttendanceRecords { get; set; }
        public ICollection<StudentCourse>? Courses { get; set; }
        public ICollection<AssignmentSubmission>? Submissions { get; set; }
        public ICollection<ExtracurricularActivity>? ExtracurricularActivities { get; set; }
        // 🔹 Auditoría
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

    }
}