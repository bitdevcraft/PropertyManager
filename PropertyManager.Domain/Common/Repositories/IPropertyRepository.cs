// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Inventories.Property;

namespace PropertyManager.Domain.Common.Repositories;

public interface IPropertyRepository
{
    void Rent(Rental rental);
    void Book();
    void GetAvailable();
    void GetAvailableRentals();
}
