using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Subject
    {
        public int Id { get; set; }
        public int gradeId { get; set; }
        public Grade? grade { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? weeklyHours { get; set; }
    }
}