// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common;
using PropertyManager.Domain.Entities.Models.Accounts.Enums;

namespace PropertyManager.Domain.Entities.Models.Accounts;

public class Account : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public AccountType Type { get; set; }
    public bool IsActive { get; set; }
    public ApplicationStatus ApplicationStatus { get; set; }

    public bool Active => IsActive && ApplicationStatus == ApplicationStatus.Approved;
}
