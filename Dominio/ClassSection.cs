using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClassSection
    {
        public int Id { get; set; }

        public int gradeId { get; set; }
        public Grade? grade { get; set; }
        public string? Name { get; set; }
        public int HomeroomTeacherId { get; set; }
        public Teacher? HomeroomTeacher { get; set; }
    }
}