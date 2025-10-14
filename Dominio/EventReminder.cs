using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class EventReminder
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event? Event { get; set; }

        public string? ReminderType { get; set; } // e.g., "Email", "SMS"
        public TimeSpan TimeBeforeEvent { get; set; } // e.g., 1 hour, 1 day

        public bool IsSent { get; set; }
        public bool IsActive { get; set; }
    }
}