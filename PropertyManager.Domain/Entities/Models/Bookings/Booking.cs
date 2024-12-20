// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Accounts;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;
using PropertyManager.Domain.Entities.Models.Inventories.Property;
using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Domain.Entities.Models.Bookings;

public class Booking : BaseEntity
{
    // Rentals
    public ICollection<Rental> Rentals { get; set; } = [];

    // General Booking Information
    public Property? Property { get; set; }
    public string? PropertyId { get; set; } // Reference to the Property
    public User? Customer { get; set; }
    public string? CustomerId { get; set; } // Reference to the Customer
    public User? Agent { get; set; }
    public string? AgentId { get; set; } // Reference to the Booking Agent
    public DateTime BookingDate { get; set; } = DateTime.UtcNow; // Set the booking date to the current date
    public string? BookingStatus { get; set; } = "Pending"; // Pending, Confirmed, Cancelled, Completed

    // Booking Duration
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DurationInDays => (EndDate - StartDate).Days;

    // Financial Details
    public decimal TotalAmount { get; set; }
    public decimal AmountPaid { get; set; }
    public decimal BalanceDue => TotalAmount - AmountPaid;
    public string? PaymentStatus { get; set; } // Paid, Partially Paid, Unpaid
    public string? PaymentMethod { get; set; } // Credit Card, Bank Transfer, Cash, etc.

    // Customer and Contact Information
    public string? CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    public string? CustomerPhone { get; set; }

    // Additional Details
    public string? Notes { get; set; } // Special requests or remarks
    public bool IsRefundable { get; set; } // Indicates if the booking is refundable

    // Payment Plan
    public PaymentPlan? PaymentPlan { get; set; }
    public string? PaymentPlanId { get; set; }
    public Dictionary<int, BookingMilestone> Installments { get; set; } = new();
}
