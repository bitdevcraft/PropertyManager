// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common.Repositories;
using PropertyManager.Domain.Common.Shared.Errors;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Models.Accounts;
using PropertyManager.Domain.Entities.Models.Accounts.Enums;

namespace PropertyManager.Persistence.Repositories.Accounts;

public class AccountRepository(AppDbContext context)
    : GenericRepository<Account>(context)
        , IAccountRepository
{
    public Result Approval(string accountId, bool isApproved)
    {
        Account? account = DbSet.FirstOrDefault(x => x.Id == accountId);

        if (account is null)
        {
            return Result.FailureResult(Error.NotFound());
        }

        account.ApplicationStatus = isApproved ? ApplicationStatus.Applied : ApplicationStatus.Rejected;

        return Result.SuccessResult();
    }
}
