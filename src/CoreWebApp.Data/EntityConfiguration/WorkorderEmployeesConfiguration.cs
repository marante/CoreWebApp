using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data
{
    /// <summary>
    /// Configuration for joining of tables between workorder and employee.
    /// </summary>
    /// <typeparam name="WorkorderEmployees"></typeparam>
    public class WorkorderEmployeesConfiguration : IEntityTypeConfiguration<WorkorderEmployees>
    {
        public void Configure (EntityTypeBuilder<WorkorderEmployees> builder)
        {
            builder.HasKey (ck => new { ck.WorkorderId, ck.EmployeeId });
            
            /*builder
                .HasOne(w => w.Workorder)
                .WithMany(w => w.WorkorderEmployees)
                .HasForeignKey(w => w.WorkorderId);
            
            builder
                .HasOne(e => e.Employee)
                .WithMany(e => e.WorkorderEmployees)
                .HasForeignKey(e => e.EmployeeId);*/
        }
    }
}