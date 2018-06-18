using CoreWebApp.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Data
{
    /// <summary>
    /// Provides configuration for fluent API. Done in separate files to not make the DbContext bloated.
    /// </summary>
    /// <typeparam name="Workorder"></typeparam>
    public class WorkorderConfiguration : IEntityTypeConfiguration<Workorder>
    {
        // Configuring each property seperatly for easier reading.
        public void Configure (EntityTypeBuilder<Workorder> builder)
        {
            builder.Property (wn => wn.ObjNr)
                .IsRequired ()
                .HasColumnName ("OBJ-NR");

            builder.Property (wd => wd.DateAdded)
                .IsRequired ()
                .HasColumnType ("Date")
                .HasDefaultValue (DateHelper.ConvertToIsoStandard ());

            builder.Property (wa => wa.Address)
                .HasMaxLength (255)
                .HasColumnName ("Adress");

            builder.Property (wd => wd.Description)
                .HasMaxLength (255)
                .HasColumnName ("Beskrivning");

            builder.Property (ws => ws.Start)
                .HasColumnName ("Start");

            builder.Property (ws => ws.Status)
                .HasColumnName ("Status");

            builder.Property (wf => wf.SentInvoice)
                .HasColumnName ("Fakturerat");

            builder.Property (we => we.WorkorderEmployees)
                .HasColumnName ("Gubbar");
        }
    }
}