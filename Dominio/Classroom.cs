using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Classroom
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public Grade? Grade { get; set; }
        public string? Name { get; set; }
        public string? description { get; set; }
        public string? RoomNUmber { get; set; }
        public int HomeroomTeacherId { get; set; }
        public Teacher? HomeroomTeacher { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}