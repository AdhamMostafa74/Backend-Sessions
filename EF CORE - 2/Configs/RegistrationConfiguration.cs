using EF_CORE___2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE___2.Configs;

internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
{
    public void Configure(EntityTypeBuilder<Registration> builder)
    {

        builder.Property(r => r.Note)
            .HasMaxLength(250);


        // each registration has one attendeen and each attendee can have many registrations
        builder
            .HasOne(r => r.Attendee)
            .WithMany(a => a.Registrations)
            .HasForeignKey(r => r.AttendeeId);

        // each registration has one event and each event has many registrations 

        builder
            .HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId);
    }
}
