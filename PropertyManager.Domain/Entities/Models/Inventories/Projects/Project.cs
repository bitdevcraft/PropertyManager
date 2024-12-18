// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;

namespace PropertyManager.Domain.Entities.Models.Inventories.Projects;

public class Project : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }

    public ICollection<ProjectPaymentPlan> PaymentPlans { get; set; } = [];
}
