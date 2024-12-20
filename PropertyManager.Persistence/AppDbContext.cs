﻿using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Authorizations.Roles;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Persistence.Seeds.DefaultDbData;

namespace PropertyManager.Persistence;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User, Role, string>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("app");
        base.OnModelCreating(builder);

        // Apply global query filter for entities implementing IAuditableEntity
        // foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
        // {
        //     // Check if the entity type implements IAuditableEntity
        //     if (typeof(IAuditableEntity).IsAssignableFrom(entityType.ClrType))
        //     {
        //         // Get the parameter expression
        //         ParameterExpression parameter = Expression.Parameter(entityType.ClrType, "e");
        //
        //         // Build the filter: e => ((IAuditableEntity)e).IsActive
        //         LambdaExpression filterExpression = Expression.Lambda(
        //             Expression.Equal(
        //                 Expression.Property(parameter, nameof(IAuditableEntity.IsDeleted)),
        //                 Expression.Constant(false)
        //             ),
        //             parameter
        //         );
        //
        //         // Apply the filter
        //         builder.Entity(entityType.ClrType)
        //             .HasQueryFilter(filterExpression);
        //     }
        // }

        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        builder.SeedData();
    }
}
