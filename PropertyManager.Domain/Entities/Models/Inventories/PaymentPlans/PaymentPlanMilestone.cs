// Copyright (c) Ryan Capio.
// All Rights Reserved.

using System.ComponentModel.DataAnnotations;
using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans.Enums;

namespace PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

public class PaymentPlanMilestone : BaseEntity
{
    /// <summary>
    /// OrderBy or the sequence of the Milestone
    /// </summary>
    public int Order { get; set; }
    
    /// <summary>
    /// Total Percentage for the Milestone
    /// </summary>
    public decimal TotalPercentage { get; set; }

    /// <summary>
    /// Number of Payment for the milestone
    /// minimum is 1
    /// </summary>
    [Range(1, int.MaxValue)]
    public int PaymentCount { get; set; } = 1;

    /// <summary>
    /// Percentage on single payment
    /// Auto-compute as TotalPercentage/PaymentCount
    /// </summary>
    public decimal Percentage =>  TotalPercentage / PaymentCount;

    /// <summary>
    /// Milestone Interval Type
    /// Default is by Month
    /// </summary>
    public MilestoneIntervalType IntervalType { get; set; }

    public PaymentPlan? PaymentPlan { get; set; }
    public string? PaymentPlanId { get; set; }
    
}
