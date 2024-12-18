using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users.RefreshTokens;

namespace PropertyManager.Domain.Common.Repositories;

public interface IRefreshTokenRepository
{
    Task<Result<RefreshToken>> CreateTokenAsync(string userId);
    Task<RefreshToken?> GetTokenAsync(string token);
    Task MarkTokenAsUsedAsync(RefreshToken token);
}
