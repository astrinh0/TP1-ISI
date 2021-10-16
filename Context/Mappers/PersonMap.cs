using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestfullAPI.Consts;
using RestfullAPI.Models;
using System;

namespace RestfullAPI.Context.Mappers
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("pn_id");

            builder.Property(t => t.Name)
                .HasColumnName("pn_nome");

            builder.Property(t => t.Email)
                .HasColumnName("pn_email");

            builder.Property(t => t.SnsNumber)
                .HasColumnName("pn_sns");

            builder.Property(t => t.Active)
                .HasColumnName("pn_active")
                .HasConversion(t => t.ToString(), t => (EnumActive)Enum.Parse(typeof(EnumActive), t));

            builder.Property(t => t.Covid)
                .HasColumnName("pn_covid")
                .HasConversion(t => t.ToString(), t => (EnumCovid)Enum.Parse(typeof(EnumCovid), t));

            builder.Property(t => t.CreateDate)
                .HasColumnName("pn_createdate");

            builder.Property(t => t.ChangeDate)
             .HasColumnName("pn_changedate");

            //FK

            builder
               .HasMany(r => r.Visits)
               .WithOne(t => t.Person)
               .HasForeignKey(r => r.PersonId);


            builder
              .HasMany(r => r.PersonContacts)
              .WithOne(t => t.ContactPerson)
              .HasForeignKey(r => r.ContactId);

            builder
             .HasMany(r => r.PersonContacts)
             .WithOne(t => t.Infected)
             .HasForeignKey(r => r.InfectedId);

            builder
             .HasMany(r => r.PersonCovids)
             .WithOne(t => t.Person)
             .HasForeignKey(r => r.PersonId);
        }
    }
}
