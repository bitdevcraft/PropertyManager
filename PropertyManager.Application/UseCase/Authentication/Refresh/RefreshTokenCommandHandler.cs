using Microsoft.AspNetCore.Identity;
using PropertyManager.Application.Abstraction.Jwt;
using PropertyManager.Application.Abstraction.Messaging;
using PropertyManager.Application.UseCase.Authentication.Login;
using PropertyManager.Domain.Common.Repositories;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Domain.Entities.Users.RefreshTokens;

namespace PropertyManager.Application.UseCase.Authentication.Refresh;

public class RefreshTokenCommandHandler(
    IRefreshTokenRepository refreshTokenRepository,
    UserManager<User> userManager,
    IJwtProvider jwtProvider)
    : ICommandHandler<RefreshTokenCommand, TokenResponse>
{
    private readonly IRefreshTokenRepository _refreshTokenRepository = refreshTokenRepository;
    private readonly UserManager<User> _userManager = userManager;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<Result<TokenResponse>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        RefreshToken? token = await _refreshTokenRepository.GetTokenAsync(request.RefreshToken);

        if (token == null || token.Expires < DateTime.UtcNow || token.IsUsed || token.IsRevoked)
        {
            return Result<TokenResponse>.FailureResult("Invalid or expired refresh token");
        }

        // Mark the token as used
        await _refreshTokenRepository.MarkTokenAsUsedAsync(token);

        // Generate new tokens
        User? user = await _userManager.FindByIdAsync(token.UserId!);

        if (user == null)
        {
            return Result<TokenResponse>.FailureResult("Invalid or expired refresh token");
        }

        string jwtToken = _jwtProvider.GenerateToken(user);
        Result<RefreshToken> newRefreshToken = await _refreshTokenRepository.CreateTokenAsync(user.Id);

        return Result<TokenResponse>
            .SuccessResult(new TokenResponse(
                jwtToken,
                newRefreshToken.Value!.Token
            ));
    }
}
