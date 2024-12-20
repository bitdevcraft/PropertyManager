// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Entities.Models.Bookings;

public class BookingStatus
{
    public int Sequence { get; set; }
    public string? Name { get; set; }

    public string? NormalizedName { get; set; }
}
