// Copyright (c) Ryan Capio.
// All Rights Reserved.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Models.Inventories.Projects;

namespace PropertyManager.Persistence.Configurations.Models;

public class ProjectPaymentPlanConfiguration : IEntityTypeConfiguration<ProjectPaymentPlan>
{
    public void Configure(EntityTypeBuilder<ProjectPaymentPlan> builder)
    {
        builder.ToTable("ProjectPaymentPlans");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => new { x.ProjectId, x.PaymentPlanId }).IsUnique();
    }
}
