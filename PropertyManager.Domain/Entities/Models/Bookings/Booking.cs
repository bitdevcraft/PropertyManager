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
    
    // General Booking Information
    public string BookingId { get; set; }
    public string PropertyId { get; set; } // Reference to the Property
    public string CustomerId { get; set; } // Reference to the Customer
    public string AgentId { get; set; } // Reference to the Booking Agent
    public DateTime BookingDate { get; set; }
    public string BookingStatus { get; set; } // Pending, Confirmed, Cancelled, Completed

    // Booking Duration
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DurationInDays => (EndDate - StartDate).Days;

    // Financial Details
    public decimal TotalAmount { get; set; }
    public decimal AmountPaid { get; set; }
    public decimal BalanceDue => TotalAmount - AmountPaid;
    public string PaymentStatus { get; set; } // Paid, Partially Paid, Unpaid
    public string PaymentMethod { get; set; } // Credit Card, Bank Transfer, Cash, etc.

    // Customer and Contact Information
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }

    // Additional Details
    public string Notes { get; set; } // Special requests or remarks
    public bool IsRefundable { get; set; } // Indicates if the booking is refundable

    // Constructor (Optional)
    public Booking()
    {
        BookingId = Guid.NewGuid().ToString(); // Generate a unique ID for the booking
        BookingDate = DateTime.Now; // Set the booking date to the current date
    }
}
