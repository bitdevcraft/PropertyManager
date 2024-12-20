// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Inventories.Property;

namespace PropertyManager.Persistence.Configurations.Models;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.ToTable("Properties");
        builder.HasKey(x => x.Id);

        builder.HasMany(p => p.Availabilities)
            .WithOne(p => p.Property)
            .HasForeignKey(p => p.PropertyId)
            .IsRequired();
    }
}
