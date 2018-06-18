using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data
{
    /// <summary>
    /// Provides configuration for fluent API. Done in separate files to not make the DbContext bloated.
    /// </summary>
    /// <typeparam name="Employee"></typeparam>
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure (EntityTypeBuilder<Employee> builder)
        {
            builder.Property (en => en.Name)
                .HasColumnType ("nvarchar(255)")
                .HasColumnName ("Namn");

            builder.Property (em => em.Email)
                .HasColumnType ("nvarchar(255)");

            builder.Property (ep => ep.PhoneNumber)
                .HasColumnType ("nvarchar(255)")
                .HasColumnName ("Telefonnummer");

            builder.Property (er => er.Role)
                .IsRequired ()
                .HasColumnName ("Arbetsroll");

            builder.Property (ew => ew.WorkorderEmployees)
                .HasColumnName ("Objekt");
        }
    }
}