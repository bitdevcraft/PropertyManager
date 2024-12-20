// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Inventories.PaymentPlans;

namespace PropertyManager.Persistence.Configurations.Models;

public class PaymentPlanMilestoneConfiguration : IEntityTypeConfiguration<PaymentPlanMilestone>
{
    public void Configure(EntityTypeBuilder<PaymentPlanMilestone> builder)
    {
        builder.ToTable("PaymentPlanMilestones");
        builder.HasKey(pm => pm.Id);

        builder.HasMany(pm => pm.Fees)
            .WithOne(f => f.Milestone)
            .HasForeignKey(f => f.MilestoneId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}
