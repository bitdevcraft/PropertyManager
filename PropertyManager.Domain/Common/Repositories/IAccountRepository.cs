// Copyright (c) Ryan Capio.
// All Rights Reserved.

namespace PropertyManager.Domain.Common.Repositories;

public interface IAccountRepository
{
    void Apply();
    void Approved();
    void Rejected();
}
