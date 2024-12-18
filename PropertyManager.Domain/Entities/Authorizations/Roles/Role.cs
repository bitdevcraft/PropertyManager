using Microsoft.AspNetCore.Identity;
using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Domain.Entities.Authorizations.Roles;

public class Role : IdentityRole, IAuditableEntity
{
    public ICollection<User> Users { get; set; } = [];

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
