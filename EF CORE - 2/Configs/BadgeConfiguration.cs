using EF_CORE___2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE___2.Configs;

internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
{
    public void Configure(EntityTypeBuilder<Badge> builder)
    {

        // each attendee has one badge , and each badge belongs to one attendee
        builder
            .HasOne(b => b.Attendee)
            .WithOne(a => a.Badge)
            .HasForeignKey<Badge>(b => b.AttendeeId);

        builder
            .HasIndex(b => b.BadgeNumber)
            .IsUnique();
            
    }
}
