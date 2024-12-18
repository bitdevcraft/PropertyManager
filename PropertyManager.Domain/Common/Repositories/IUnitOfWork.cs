// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Common.Repositories;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
