using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public int AttendanceSessionId { get; set; }
        public AttendanceSession? AttendanceSession { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public string? Status { get; set; } = "Present"; // Present, Absent, Excused, Tardy
        public bool IsExcused { get; set; } = false;
        public TimeSpan? MinutesLate { get; set; }
        public string? Reason { get; set; }
        public string? ExcuseDocumentUrl { get; set; }
        public string? Source { get; set; } // Manual, MobileApp, WebApp
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public DateTime MarkedAtUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }

    }
}