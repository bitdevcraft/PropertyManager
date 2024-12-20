// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Bookings;

namespace PropertyManager.Domain.Common.Repositories;

public interface IBookingRepository
{
    /// <summary>
    /// Get all the Customers Bookings
    /// </summary>
    /// <returns></returns>
    List<Booking> GetCustomerBookings(string userId);

    /// <summary>
    /// Get all the Owner's owned property bookings by account ID
    /// </summary>
    /// <returns></returns>
    List<Booking> GetOwnedBookingsByAccount(string accountId);

    /// <summary>
    /// Get all the Owner's owned property bookings by user ID
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    List<Booking> GetOwnedBookingsByUser(string userId);
}
