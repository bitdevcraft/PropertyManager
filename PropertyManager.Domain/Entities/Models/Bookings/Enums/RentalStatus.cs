// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Entities.Models.Bookings.Enums;

public enum BookingStatus
{
    Pending,
    AwaitingPayment,
    Confirmed,
    Cancelled,
    Completed,
    NoShow,
    Refunded,
    InProgress,
    Failed,
    Expired,
}
