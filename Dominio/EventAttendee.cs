using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class EventAttendee
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public string? kind { get; set; } // e.g., "Student", "Teacher", "Parent"
        public int AttendeeId { get; set; } // ID of the student, teacher, or parent

        public string? ExternalName { get; set; } // Name for external attendees
        public string? ExternalEmail { get; set; } // Email for external attendees
        public string? RsvpStatus { get; set; } // e.g., "Accepted", "Declined", "Pending"
        public bool Attended { get; set; } // Whether the attendee actually attended
    }
}