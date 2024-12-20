// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Entities.Models.Bookings;

public record BookingMilestone(
    string Name,
    decimal Percentage,
    decimal Price,
    DateTime DueDate,
    string Remarks,
    bool IsPaid
);
