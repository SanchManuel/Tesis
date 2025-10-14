using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasKey(t => new { t.userId, t.SchoolId });
        }

        // Define DbSets for your entities here
        // public DbSet<YourEntity> YourEntities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<AttendanceSession> AttendanceSessions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ExtracurricularActivity> ExtracurricularActivities { get; set; }
        public DbSet<LibraryBook> LibraryBooks { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamSubmission> ExamSubmissions { get; set; }
        public DbSet<ExamSubmissionAnswer> ExamSubmissionAnswers { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<LibraryCopy> LibraryCopies { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StateRegulatoryDependencies> StateRegulatoryDependencies { get; set; }
        public DbSet<Department> Departments { get; set; }



    }
}