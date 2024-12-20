// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Domain.Entities.Models.Inventories.Projects;

public class ProjectPaymentPlan : BaseEntity
{
    public Project? Project { get; set; }
    public string? ProjectId { get; set; }
    public PaymentPlan? PaymentPlan { get; set; }
    public string? PaymentPlanId { get; set; }
}
