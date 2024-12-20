using Microsoft.EntityFrameworkCore;
using PropertyManager.Domain.Common.Repositories;
using PropertyManager.Domain.Common.Shared.Errors;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users.RefreshTokens;

namespace PropertyManager.Persistence.Repositories.RefreshTokens;

public class RefreshTokenRepository(AppDbContext context) : IRefreshTokenRepository
{
    private readonly AppDbContext _context = context;
    private readonly DbSet<RefreshToken> _dbSet = context.Set<RefreshToken>();

    public async Task<Result<RefreshToken>> CreateTokenAsync(string userId)
    {
        var refreshToken = new RefreshToken
        {
            Token = Guid.NewGuid().ToString(),
            UserId = userId,
            Expires = DateTime.UtcNow.AddDays(7), // Example: 7 days expiration
            Created = DateTime.UtcNow,
            IsUsed = false,
            IsRevoked = false
        };

        _dbSet.Add(refreshToken);
        bool result = await _context.SaveChangesAsync() > 0;

        if (!result)
        {
            Result<RefreshToken>.FailureResult(Error.Failure("Failed to create refresh token"));
        }

        return Result<RefreshToken>.SuccessResult(refreshToken);
    }

    public async Task<RefreshToken?> GetTokenAsync(string token)
    {
        return await _dbSet
            .FirstOrDefaultAsync(
                t =>
                    t.Token == token && !t.IsUsed && !t.IsRevoked
            );
    }

    public async Task MarkTokenAsUsedAsync(RefreshToken token)
    {
        token.IsUsed = true;
        await _context.SaveChangesAsync();
    }
}
