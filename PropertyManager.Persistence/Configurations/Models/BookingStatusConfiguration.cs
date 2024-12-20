// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Bookings;

namespace PropertyManager.Persistence.Configurations.Models;

public class BookingStatusConfiguration : IEntityTypeConfiguration<BookingStatus>
{
    public void Configure(EntityTypeBuilder<BookingStatus> builder)
    {
        builder.ToTable("BookingStatus");
        builder.HasKey(x => x.Name);

        builder.Property(x => x.Sequence)
            .ValueGeneratedOnAdd();

        builder.HasIndex(x => x.NormalizedName).IsUnique();
        builder.Property(x => x.Name).IsRequired();

        builder.HasData([
            new BookingStatus { Name = "Pending", NormalizedName = "Pending".ToUpperInvariant() },
            new BookingStatus { Name = "Confirmed", NormalizedName = "Confirmed".ToUpperInvariant() },
            new BookingStatus { Name = "Cancelled", NormalizedName = "Cancelled".ToUpperInvariant() },
            new BookingStatus { Name = "Completed", NormalizedName = "Completed".ToUpperInvariant() },
        ]);
    }
}
