using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class EventAudience
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event? Event { get; set; }

        public string? AudienceType { get; set; } // e.g., "Grade", "ClassSection", "Individual"
        public int AudienceId { get; set; } // ID of the grade, class section, or individual
    }
}