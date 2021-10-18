using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Consts;
using RestfullAPI.Models;
using System;

namespace RestfullAPI.Context.Mappers
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("us_id");

            builder.Property(t => t.Username)
                .HasColumnName("us_username");

            builder.Property(t => t.Password)
               .HasColumnName("us_password");

            builder.Property(t => t.Active)
              .HasColumnName("rq_status")
              .HasConversion(t => t.ToString(), t => (EnumActive)Enum.Parse(typeof(EnumActive), t));

            
        }
    }
}
