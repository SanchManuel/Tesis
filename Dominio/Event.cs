using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Event
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? EventType { get; set; } // e.g., Holiday, Exam, Meeting

        public bool IsEvenVisibility { get; set; } // true if visible to everyone, false if restricted

        public DateTime StartAtUtc { get; set; }
        public DateTime EndAtUtc { get; set; }

        public bool IsAllDay { get; set; }
        public string? TimezoneId { get; set; } // e.g., "America/New_York"

        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }

        public string? LocationText { get; set; } // e.g., "Room 101", "Online"

        public ICollection<EventAudience>? Audiences { get; set; }
        public ICollection<EventAttendee>? Attendees { get; set; }
        public ICollection<EventReminder>? Reminders { get; set; }

        public ICollection<EventAttachment>? Attachments { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAtUtc { get; set; }
    }

}