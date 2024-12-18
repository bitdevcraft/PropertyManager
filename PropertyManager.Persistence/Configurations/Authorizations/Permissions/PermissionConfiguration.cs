using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Entities.Authorizations.Permissions;

namespace PropertyManager.Persistence.Configurations.Authorizations.Permissions;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("Permissions", "admin");
        builder.HasKey(p => p.Id);
    }
}
