// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Domain.Common.Repositories;

public interface IAccountRepository
{
    Result Approval(string accountId, bool isApproved);
}
