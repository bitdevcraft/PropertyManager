using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Authorizations.Permissions;

namespace PropertyManager.Persistence.Configurations.Authorizations.Permissions;

public class PermissionActionConfiguration : IEntityTypeConfiguration<PermissionAction>
{
    public void Configure(EntityTypeBuilder<PermissionAction> builder)
    {
        builder.ToTable("PermissionActions", "admin");
        builder.HasKey(pa => pa.Id);
    }
}
