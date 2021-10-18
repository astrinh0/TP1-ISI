using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Models;

namespace RestfullAPI.Context.Mappers
{
    public class VisitMap : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.ToTable("Visit");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("vs_id");

            builder.Property(t => t.PersonId)
                .HasColumnName("vs_pn_id");

            builder.Property(t => t.Transgressions)
                .HasColumnName("vs_transgressions");

            builder.Property(t => t.CreateDate)
                .HasColumnName("pnc_createdate");

            //FK

            builder
                 .HasOne(c => c.Person)
                 .WithMany(pc => pc.Visits)
                 .HasForeignKey(pc => pc.PersonId);


        }
    }
}
