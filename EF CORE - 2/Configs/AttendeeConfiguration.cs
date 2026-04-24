using EF_CORE___2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE___2.Configs
{
    internal class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.Property(a => a.Email).IsRequired().HasMaxLength(100);
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(100);

            builder.OwnsOne(a => a.Address);

            builder.HasIndex(a => a.Email).IsUnique();
        }
    }
}
