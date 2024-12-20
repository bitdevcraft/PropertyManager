// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Persistence.Configurations.Models;

public class PaymentPlanConfiguration : IEntityTypeConfiguration<PaymentPlan>
{
    public void Configure(EntityTypeBuilder<PaymentPlan> builder)
    {
        builder.ToTable("PaymentPlans");
        builder.HasKey(x => x.Id);

        builder.HasMany(pp => pp.Milestones)
            .WithOne(m => m.PaymentPlan)
            .HasForeignKey(m => m.PaymentPlanId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}
