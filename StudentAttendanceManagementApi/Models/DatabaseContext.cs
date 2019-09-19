using System;
using Microsoft.EntityFrameworkCore;

namespace StudentAttendanceManagementApi.Models
{
    public class DatabaseContext : DbContext
    {
        private static DatabaseContext _context;

        private DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
            Subjects.Add(new Subject() { SubjectName = "Maths" });
            Subjects.Add(new Subject() { SubjectName = "English" });
            Subjects.Add(new Subject() { SubjectName = "Hindi" });
            SaveChanges();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Attendance> Attendance { get; set; }

        public static DatabaseContext GetInstance()
        {
            if (_context == null)
                _context = new DatabaseContext(new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase("Database").Options);
            return _context;
        }
    }
}
