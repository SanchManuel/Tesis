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
        public int StateId { get; set; }
        public State? state { get; set; }
        public string? ZipCode { get; set; }
        public string? ClaveCCT { get; set; }
        public StateRegulatoryDependencies? stateRegulatoryDependencies { get; set; }
        public int StateRegulatoryDependenciesId { get; set; }
        public DateTime FoundationDate { get; set; }
        public DateTime DateReport { get; set; }
        public string? SchoolZone { get; set; }
        public string? Sector { get; set; }
        public string? Modality { get; set; }
        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Classroom>? Classrooms { get; set; }
        public List<Subject>? Subjects { get; set; }
        public List<Grade>? Grades { get; set; }
        public ICollection<AttendanceSession>? AttendanceSessions { get; set; }
        public List<Event>? Events { get; set; }
        public List<Staff>? StaffMembers { get; set; }
        public List<Parent>? Parents { get; set; }
        public List<ExtracurricularActivity>? ExtracurricularActivities { get; set; }
        public List<LibraryBook>? LibraryBooks { get; set; }
        public ICollection<Exam>? Exams { get; set; }
        public List<Transportation>? Transportations { get; set; }
        public ICollection<CourseSchedule>? Schedules { get; set; }
        public ICollection<LibraryCopy>? LibraryCopies { get; set; }

    }
}