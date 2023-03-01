using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Data.Converters;
using SchoolAdministration.Data.Models;

namespace ConferencePlanner.GraphQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>();
        }
        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<Teacher> Teachers { get; set; } = default!;
        public DbSet<TestResult> TestResults { get; set; } = default!;
        public DbSet<Class> Classes { get; set; } = default!;
    }
}