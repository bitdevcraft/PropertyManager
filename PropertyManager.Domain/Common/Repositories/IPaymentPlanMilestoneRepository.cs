// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Domain.Common.Repositories;

public interface IPaymentPlanMilestoneRepository
{
    void UpdateSequence(List<PaymentPlanMilestone> paymentPlanMilestones);

    List<PaymentPlanMilestone> GetByPaymentPlanId(string paymentPlanId);
}
