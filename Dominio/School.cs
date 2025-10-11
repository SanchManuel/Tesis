using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class School
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int countryId { get; set; }
        public Country? country { get; set; }
        public int stateId { get; set; }
        public State? state { get; set; }
        public string? zipCode { get; set; }
        public string? claveCCT { get; set; }
        public StateRegulatoryDependencies? stateRegulatoryDependencies { get; set; }
        public int stateRegulatoryDependenciesId { get; set; }
        public DateTime foundationDate { get; set; }
        public DateTime dateReport { get; set; }
        public string? scholZone { get; set; }
        public string? sector { get; set; }
        public string? modality { get; set; }
        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Classroom>? Classrooms { get; set; }
        public List<Subject>? Subjects { get; set; }
        public List<Schedule>? Schedules { get; set; }
        public List<Grade>? Grades { get; set; }
        public List<Attendance>? Attendances { get; set; }
        public List<Event>? Events { get; set; }
        public List<Staff>? StaffMembers { get; set; }
        public List<Parent>? Parents { get; set; }
        public List<ExtracurricularActivity>? ExtracurricularActivities { get; set; }
        public List<LibraryBook>? LibraryBooks { get; set; }
        public List<Exam>? Exams { get; set; }
        public List<Transportation>? Transportations { get; set; }

    }
}