
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; } //student table
        public DbSet<Courses> Courses { get; set; } //student table

        public IQueryable<Courses> GetCoursesByStudentId(int studentid, int courseId)
        {
            var pstudentid = new SqlParameter("@StudentId", studentid);
            var pcourseId = new SqlParameter("@CourseId", courseId);
            return this.Courses.FromSqlRaw("EXECUTE GetStudentsByCourseId @StudentId, @CourseId", pstudentid, pcourseId);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseSqlServer(
                    @"Server=(local); Database=StudentsDatabase; Trusted_Connection=True;",
                    options => options.EnableRetryOnFailure());
    }
}
