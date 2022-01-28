
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; } //student table
        public DbSet<Courses> Courses { get; set; } //student table

        public IQueryable<Courses> GetStudentsByCourseId(int id)
        {
            var pId = new SqlParameter("@CourseId", id);
            return this.Courses.FromSqlRaw("EXECUTE GetStudentsByCourseId @CourseId", pId);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseSqlServer(
                    @"Server=(local); Database=StudentsDatabase; Trusted_Connection=True;",
                    options => options.EnableRetryOnFailure());
    }
}
