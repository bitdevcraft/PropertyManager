// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Persistence.Configurations.Models;

public class PaymentPlanFeeConfiguration : IEntityTypeConfiguration<PaymentPlanFee>
{
    public void Configure(EntityTypeBuilder<PaymentPlanFee> builder)
    {
        builder.ToTable("PaymentPlanFees");
        builder.HasKey(x => x.Id);
    }
}
