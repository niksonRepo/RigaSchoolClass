
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(local); Database=UniversityDB; Trusted_Connection=True;");
    }
}
