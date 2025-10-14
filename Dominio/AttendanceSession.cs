using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AttendanceSession
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int classSectionId { get; set; }
        public ClassSection? ClassSection { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int ClassRoomId { get; set; }
        public Classroom? Classroom { get; set; }
        public DateOnly SessionDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string? TimeZoneId { get; set; } = "America/Mexico_City";

        public bool isOpen { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ClosedAt { get; set; }
        public ICollection<AttendanceRecord>? Records { get; set; }
    }
}