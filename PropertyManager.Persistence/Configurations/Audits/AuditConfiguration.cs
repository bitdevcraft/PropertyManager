using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyManager.Domain.Common.Auditable;

namespace PropertyManager.Persistence.Configurations.Audits;

internal sealed class AuditConfiguration : IEntityTypeConfiguration<Audit>
{
    public void Configure(EntityTypeBuilder<Audit> builder)
    {
        builder.ToTable("Audits", "audit");

        builder.HasKey(x => x.Id);
    }
}
