using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class StudentParent
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int ParentId { get; set; }
        public Parent? Parent { get; set; }

        public string? Relationship { get; set; }
        public string? priority { get; set; }

        public bool IsEmergencyContact { get; set; }
        public bool LivesWithStudent { get; set; }
        public string? Custody { get; set; }
        public bool CanPickUp { get; set; }
        public string? Notes { get; set; }
        public DateTime LinkedAt { get; set; }
        public bool IsActive { get; set; }

    }
}