
using EF_CORE___2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE___2.Configs;

internal class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {

        builder.Property(e => e.Title).HasMaxLength(100);

        // relation with organizer , organizer can organize many events but event can have only one organizer
        builder
            .HasOne(e => e.Organizer)
            .WithMany(o => o.Events)
            .HasForeignKey(e => e.OrganizerId);

        // relation with sessions , events can have many sessions but session can belong to only one event

        builder
            .HasMany(e => e.Sessions)
            .WithOne(s => s.Event)
            .HasForeignKey(s => s.EventId);
    }


}
