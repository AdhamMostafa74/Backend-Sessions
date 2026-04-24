
using EF_CORE___2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE___2.Configs;

public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
{
    public void Configure(EntityTypeBuilder<Organizer> builder)
    {
        builder.Property(o => o.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(o => o.CompanyName)
            .HasMaxLength(100);
        
      
        // owned entity 
        builder
            .OwnsOne(o => o.OrganizerProfile);
    }
}
