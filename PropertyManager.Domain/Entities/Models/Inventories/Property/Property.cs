// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.Base;
using PropertyManager.Domain.Entities.Models.Inventories.Projects;
using PropertyManager.Domain.Entities.Models.Inventories.Property.Enums;

namespace PropertyManager.Domain.Entities.Models.Inventories.Property;

public class Property : BaseItem
{
    public string? ProjectId { get; set; }
    public Project? Project { get; set; }

    public PropertyCategory Category { get; set; }
    public PropertyType Type { get; set; }

    // Rental
    public TimeSpan TimeIn { get; set; }
    public TimeSpan TimeOut { get; set; }
    public ICollection<Rental> Availabilities { get; set; } = [];
}
