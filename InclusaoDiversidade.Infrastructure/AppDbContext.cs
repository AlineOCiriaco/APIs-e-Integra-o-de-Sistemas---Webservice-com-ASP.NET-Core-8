using InclusaoDiversidade.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InclusaoDiversidade.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Mapeamento das Entidades:
        public DbSet<Completion> Completions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DiversityReport> DiversityReports { get; set; }
        public DbSet<EmailOutbox> EmailOutbox { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Training> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiversityReport>()
         .HasKey(r => r.ReportId);

           
            modelBuilder.Entity<DiversityReport>()
                .HasOne(r => r.Department)
                .WithMany() 
                .HasForeignKey(r => r.DepartmentDepartmentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}