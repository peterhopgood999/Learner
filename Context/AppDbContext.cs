using Microsoft.EntityFrameworkCore;
using Learner.Entities;

namespace Learner.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<AbsenteeHistory> AbsenteeHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the foreign key relationship
            modelBuilder.Entity<AbsenteeHistory>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId);
        }
    }
}