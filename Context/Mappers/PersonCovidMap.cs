using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Models;

namespace RestfullAPI.Context.Mappers
{
    public class PersonCovidMap : IEntityTypeConfiguration<PersonCovid>
    {
        public void Configure(EntityTypeBuilder<PersonCovid> builder)
        {
            builder.ToTable("PersonCovid");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("pcd_id");

            builder.Property(t => t.PersonId)
                .HasColumnName("pcd_pn_id");

            builder.Property(t => t.Date)
                .HasColumnName("pcd_date");

            builder.Property(t => t.CreateDate)
                .HasColumnName("pcd_createdate");

            //FK

            builder
                 .HasOne(c => c.Person)
                 .WithMany(pc => pc.PersonCovids)
                 .HasForeignKey(pc => pc.PersonId);

          

        }
    }
}
