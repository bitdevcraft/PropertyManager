// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans.Enums;

namespace PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

public class PaymentPlanFee : BaseEntity
{
    public string? Name { get; set; }
    public decimal AmountOrRate { get; set; }
    public bool IsRecurring  { get; set; }
    public MilestoneFeeType Type { get; set; }

    public PaymentPlanMilestone? Milestone { get; set; }
    public string? MilestoneId { get; set; }
}
