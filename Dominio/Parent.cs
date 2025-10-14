using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Dominio
{
    public class Parent
    {
        public int id { get; set; }
        public int SchoolId { get; set; }

        public string? FristName { get; set; }
        public string? LastName { get; set; }

        public string? MiddleName { get; set; }
        public string? NationalId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? PhotoUrl { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? PhoneAlt { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Occupation { get; set; }
        public string? WorkPlace { get; set; }
        public string? WorkPhone { get; set; }
        public bool ReceiveEmail { get; set; }
        public bool ReceiveSMS { get; set; }
        public string? PreferedLanguage { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public ICollection<StudentParent>? Students { get; set; }

        // Auditoría
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

    }
}