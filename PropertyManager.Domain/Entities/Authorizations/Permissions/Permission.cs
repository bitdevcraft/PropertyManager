using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Authorizations.Roles;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Domain.Metadata;

namespace PropertyManager.Domain.Entities.Authorizations.Permissions;

public class Permission : BaseEntity, IAuditableEntity
{
    public Role? Role { get; set; }
    public string? RoleId { get; set; }

    public PermissionAction? Action { get; set; }
    public string? ActionId { get; set; }

    public ObjectMetadata? ObjectMetadata { get; set; }
    public string? ObjectMetadataId { get; set; }

    public ObjectFieldMetadata? ObjectFieldMetadata { get; set; }
    public string? ObjectFieldMetadataId { get; set; }

    public bool CanCreate { get; set; }
    public bool CanRead { get; set; }
    public bool CanEdit { get; set; }
    public bool CanDelete { get; set; }

    // Auditable

    public DateTime? CreatedAt { get; set; }
    public User? CreatedBy { get; set; }
    public string? CreatedById { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public User? UpdatedBy { get; set; }
    public string? UpdatedById { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public User? DeletedBy { get; set; }
    public string? DeletedById { get; set; }
}
