// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Models.Bookings;
using PropertyManager.Domain.Entities.Models.Inventories.Property;

namespace PropertyManager.Domain.Common.Repositories;

public interface IPropertyRepository
{
    List<Property> GetAvailable();
    List<Property> GetAvailableRentals();
    List<Property> GetByAccountId(string accountId);
    List<Property> GetByProjectId(string projectId);
    void BulkInsert(IEnumerable<Property> properties);
    
    void BulkUpsert(IEnumerable<Property> properties);
    
    void BulkUpdate(IEnumerable<Property> properties);
}
