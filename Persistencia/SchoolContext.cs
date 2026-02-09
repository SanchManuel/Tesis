using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>(e =>
            {
                e.HasKey(t => t.Id);

                e.HasIndex(x => new { x.UserId, x.SchoolId })
                .IsUnique();

                e.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Student>(e =>
            {
                e.HasKey(s => s.Id);

                e.HasIndex(x => new { x.UserId, x.SchoolId })
                .IsUnique();

                e.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Parent>(e =>
           {
               e.HasKey(p => p.Id);

               e.HasIndex(x => new { x.UserId, x.SchoolId })
               .IsUnique();

               e.HasOne(x => x.User)
               .WithMany()
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Restrict);

               e.HasOne(x => x.School)
               .WithMany()
               .HasForeignKey(x => x.SchoolId)
               .OnDelete(DeleteBehavior.Restrict);
           });

            modelBuilder.Entity<Staff>(e =>
            {
                e.HasKey(s => s.Id);

                e.HasIndex(x => new { x.UserId, x.SchoolId })
                .IsUnique();

                e.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<ExamSubmissionAnswer>()
                .HasKey(esa => new { esa.ExamSubmissionId, esa.ExamQuestionId });

            modelBuilder.Entity<ExamQuestion>()
                .HasKey(eq => new { eq.Id, eq.ExamId });

            modelBuilder.Entity<StateRegulatoryDependencies>()
                .HasKey(srd => new { srd.StateId, srd.Id });

            modelBuilder.Entity<State>()
                .HasKey(s => new { s.Id, s.CountryId });

            modelBuilder.Entity<ActivityEnrollment>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasIndex(x => new { x.StudentId, x.ExtracurricularActivityId, x.SchoolId }).IsUnique();

                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Student)
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.ExtracurricularActivity)
                .WithMany()
                .HasForeignKey(x => x.ExtracurricularActivityId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<Assignment>(e =>
            {
                e.HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(e => e.Teacher)
                .WithMany()
                .HasForeignKey(e => e.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.ClassSection)
                .WithMany()
                .HasForeignKey(x => x.classSectionId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<AssignmentAttachment>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasIndex(x => x.AssignmentId);

                e.HasOne(x => x.Assignment)
                .WithMany()
                .HasForeignKey(x => x.AssignmentId)
                .OnDelete(DeleteBehavior.Cascade);

                e.Property(x => x.FileName).HasMaxLength(255);
                e.Property(x => x.ContentType).HasMaxLength(100);
                e.Property(x => x.StorageUrl).HasMaxLength(500);
            });
            modelBuilder.Entity<AssignmentSubmission>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasIndex(x => new { x.AssignmentId, x.StudentId }).IsUnique();

                e.HasOne(x => x.Assignment)
                .WithMany()
                .HasForeignKey(x => x.AssignmentId)
                .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(x => x.Student)
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.GradedByTeacher)
                .WithMany()
                .HasForeignKey(x => x.GradedByTeacherId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<SubmissionFile>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasIndex(x => x.AssignmentSubmissionId);

                e.HasOne(x => x.AssignmentSubmission)
                .WithMany(s => s.Files)
                .HasForeignKey(x => x.AssignmentSubmissionId)
                .OnDelete(DeleteBehavior.Cascade);

                e.Property(x => x.FileName).HasMaxLength(255);
                e.Property(x => x.ContentType).HasMaxLength(100);
                e.Property(x => x.StorageUrl).HasMaxLength(500);
            });
            modelBuilder.Entity<AttendanceSession>(e =>
            {
                e.HasKey(x => x.Id);
                e.HasIndex(x => new { x.SchoolId, x.SessionDate });
                e.HasIndex(x => x.classSectionId);
                e.HasIndex(x => x.TeacherId);

                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.ClassSection)
                .WithMany()
                .HasForeignKey(x => x.classSectionId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.School)
                .WithMany(t => t.AttendanceSessions)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Classroom)
                .WithMany()
                .HasForeignKey(x => x.ClassRoomId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<AttendanceRecord>(e =>
            {
                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.AttendanceSession)
                .WithMany()
                .HasForeignKey(x => x.AttendanceSessionId)
                .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(x => x.Student)
                .WithMany(s => s.AttendanceRecords)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.Status).HasMaxLength(20);
                e.Property(x => x.Source).HasMaxLength(20);
                e.Property(x => x.ExcuseDocumentUrl).HasMaxLength(500);
            });
            modelBuilder.Entity<Classroom>(e =>
            {
                e.HasKey(x => x.Id);
                e.HasIndex(x => new { x.SchoolId, x.Name }).IsUnique();
                e.Property(x => x.Name).IsRequired().HasMaxLength(120);
                e.Property(x => x.Description).HasMaxLength(500);
                e.Property(x => x.RoomNumber).HasMaxLength(50);
                e.Property(x => x.MeetingUrl).HasMaxLength(500);
                e.Property(x => x.Platform).HasMaxLength(50);
                e.Property(x => x.MeetingCode).HasMaxLength(50);
                e.HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<ClassSection>(e =>
            {
                e.HasKey(x => x.Id);
            });
            modelBuilder.Entity<Country>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(100);
                e.Property(x => x.Code).IsRequired().HasMaxLength(3);
                e.HasIndex(x => x.Code).IsUnique();
            });


        }

        public DbSet<User> Users { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<AttendanceSession> AttendanceSessions { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ExtracurricularActivity> ExtracurricularActivities { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamSubmission> ExamSubmissions { get; set; }
        public DbSet<ExamSubmissionAnswer> ExamSubmissionAnswers { get; set; }
        public DbSet<Transportation> Transportation { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StateRegulatoryDependencies> StateRegulatoryDependencies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ActivityEnrollment> ActivityEnrollments { get; set; }
        public DbSet<AssignmentAttachment> AssignmentAttachments { get; set; }
        public DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<ClassSection> ClassSections { get; set; }
        public DbSet<CourseScheduleException> CourseScheduleExceptions { get; set; }
        public DbSet<EventAttendee> EventAttendees { get; set; }
        public DbSet<EventAudience> EventAudiences { get; set; }
        public DbSet<EventReminder> EventReminders { get; set; }
        public DbSet<EventAttachment> EventAttachments { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<LibraryBook> LibraryBook { get; set; }
        public DbSet<LibraryCopy> LibraryCopy { get; set; }
        public DbSet<LibraryLoan> LibraryLoan { get; set; }
        public DbSet<Modulo> Modulus { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<SubmissionFile> SubmissionFiles { get; set; }
        public DbSet<TypeFinancing> TypeFinancing { get; set; }
    }
}