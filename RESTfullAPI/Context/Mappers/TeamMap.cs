using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Consts;
using RestfullAPI.Models;
using System;

namespace RestfullAPI.Context.Mappers
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("tm_id");

            builder.Property(t => t.Name)
                .HasColumnName("tm_name");

            builder.Property(t => t.Active)
                .HasColumnName("tm_active")
                .HasConversion(t => t.ToString(), t => (EnumActive)Enum.Parse(typeof(EnumActive), t));

            builder.Property(t => t.CreateDate)
                .HasColumnName("tm_createdate");

            builder.Property(t => t.ChangeDate)
             .HasColumnName("tm_changedate");


            //FK

            builder
                .HasMany(r => r.Requisitions)
                .WithOne(t => t.Team)
                .HasForeignKey(r => r.TeamId);

           

        }
    }
}
