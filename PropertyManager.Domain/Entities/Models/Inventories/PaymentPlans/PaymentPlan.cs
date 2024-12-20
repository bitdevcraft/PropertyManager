// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;

namespace PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

public class PaymentPlan : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public ICollection<PaymentPlanMilestone> Milestones { get; set; } = [];
}
