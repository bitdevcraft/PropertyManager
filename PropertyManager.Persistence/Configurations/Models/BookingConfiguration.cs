// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Bookings;

namespace PropertyManager.Persistence.Configurations.Models;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("Bookings");
        builder.HasKey(x => x.Id);

        builder.HasMany(b => b.Rentals)
            .WithOne(r => r.Booking)
            .HasForeignKey(r => r.BookingId)
            .IsRequired(false);

        builder.Property(x => x.Installments)
            .HasColumnType("jsonb");
    }
}
