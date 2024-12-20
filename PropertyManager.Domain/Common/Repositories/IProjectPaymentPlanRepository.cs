// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.Projects;

namespace PropertyManager.Domain.Common.Repositories;

public interface IProjectPaymentPlanRepository
{
    void AddPaymentPlan(ProjectPaymentPlan projectPaymentPlan);
    
    List<ProjectPaymentPlan> GetByProjectId(string projectId);

}
