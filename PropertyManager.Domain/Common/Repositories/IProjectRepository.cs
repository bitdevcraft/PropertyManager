// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.Projects;

namespace PropertyManager.Domain.Common.Repositories;

public interface IProjectRepository
{
    void AddPaymentPlan(ProjectPaymentPlan projectPaymentPlan);
    void GetPaymentPlans(string projectId);
    void GetWithProperties(string propertyId);
}
