
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; } //student table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(local); Database=UniversityDB1; Trusted_Connection=True;");
    }
}
