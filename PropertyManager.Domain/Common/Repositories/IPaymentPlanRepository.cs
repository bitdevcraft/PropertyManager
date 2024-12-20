// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Domain.Common.Repositories;

public interface IPaymentPlanRepository
{
    List<PaymentPlan> GetByAccountId(string accountId);
}
