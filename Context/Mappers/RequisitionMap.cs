using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Consts;
using RestfullAPI.Models;
using System;

namespace RestfullAPI.Context.Mappers
{
    public class RequisitionMap : IEntityTypeConfiguration<Requisition>
    {
        public void Configure(EntityTypeBuilder<Requisition> builder)
        {
            builder.ToTable("Requisition");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("rq_id");

            builder.Property(t => t.TeamId)
                .HasColumnName("rq_tm_id");

            builder.Property(t => t.Status)
                .HasColumnName("rq_status")
                .HasConversion(t => t.ToString(), t => (EnumStatus)Enum.Parse(typeof(EnumStatus), t)); 

            builder.Property(t => t.CreateDate)
                .HasColumnName("rq_createdate");

            //FK

            builder
              .HasMany(r => r.RequisitionProducts)
              .WithOne(t => t.Requisition)
              .HasForeignKey(r => r.RequisitionId);

        }
    }
}
