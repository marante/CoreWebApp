using Microsoft.EntityFrameworkCore;

namespace CoreWebApp.Data
{
    public class WorkorderDbContext : DbContext
    {
        public WorkorderDbContext (DbContextOptions options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            // Applying all custom configurations.
            modelBuilder.
                ApplyConfiguration(new WorkorderConfiguration()).
                ApplyConfiguration(new EmployeeConfiguration()).
                ApplyConfiguration(new WorkorderEmployeesConfiguration());
        }

        public DbSet<Workorder> Workorder { get; set; }
        public DbSet<Employee> Employee { get; set; }
        
        // Not certain that this is needed.
        //public DbSet<WorkorderEmployees> WorkorderEmployees { get; set; }
    }
}