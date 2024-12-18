// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

public class PaymentPlan
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public ICollection<PaymentPlanMilestone> Milestones { get; set; } = [];
}
