// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Bookings;
using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Domain.Entities.Models.Inventories.Property;

public class Rental : BaseEntity
{
    public Property? Property { get; set; }
    public string? PropertyId { get; set; }

    public DateTime? CheckIn { get; set; }
    public DateTime? CheckOut { get; set; }

    public bool IsAvailable { get; set; }
    public decimal Price { get; set; }

    public Booking? Booking { get; set; }
    public string? BookingId { get; set; }
}
