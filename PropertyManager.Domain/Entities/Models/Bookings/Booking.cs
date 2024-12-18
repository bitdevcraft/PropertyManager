// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Inventories.Property;
using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Domain.Entities.Models.Bookings;

public class Booking : BaseEntity
{
    public Property? Property { get; set; }
    public string? PropertyId { get; set; }

    public User? MainCustomer { get; set; }
    public string? MainCustomerId { get; set; }
    
    // Rentals
    public ICollection<Rental> Rentals { get; set; }
}
