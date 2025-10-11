using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Grade
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? code { get; set; }
        public string? EducationStage { get; set; }
        public int DisplayOrder { get; set; }
        public int schoolId { get; set; }
        public School? school { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}