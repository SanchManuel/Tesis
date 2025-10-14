using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class ActivityEnrollment
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public int ExtracurricularActivityId { get; set; }
        public ExtracurricularActivity? ExtracurricularActivity { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public bool IsActive { get; set; }
    }
}