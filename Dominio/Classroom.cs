using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public enum ClassroomType
    {
        Physical = 1,
        Virtual = 2
    }
    public class Classroom
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }
        public School? School { get; set; }

        public string Name { get; set; } = null!;      // "Aula 12", "Zoom - 3A"
        public string? Description { get; set; }

        public ClassroomType Type { get; set; }        // Physical / Virtual

        // Físico
        public string? RoomNumber { get; set; }
        public int? Capacity { get; set; }
        public string? Building { get; set; }

        // Virtual
        public string? MeetingUrl { get; set; }        // link meet/zoom/teams
        public string? Platform { get; set; }          // "Meet", "Zoom", "Teams"
        public string? MeetingCode { get; set; }       // opcional

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}