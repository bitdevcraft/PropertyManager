using Microsoft.AspNetCore.Identity;
using PropertyManager.Application.Abstraction.Jwt;
using PropertyManager.Application.Abstraction.Messaging;
using PropertyManager.Domain.Common.Repositories;
using PropertyManager.Domain.Common.Shared.Errors;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Domain.Entities.Users.RefreshTokens;

namespace PropertyManager.Application.UseCase.Authentication.Login;

public class LoginCommandHandler(
    UserManager<User> userManager,
    IJwtProvider jwtProvider,
    IRefreshTokenRepository refreshTokenRepository
)
    : ICommandHandler<LoginCommand, TokenResponse>
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IRefreshTokenRepository _refreshTokenRepository = refreshTokenRepository;

    public async Task<Result<TokenResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userManager.FindByNameAsync(request.Login.Username);

        if (user == null || !await _userManager.CheckPasswordAsync(user, request.Login.Password))
        {
            return Result<TokenResponse>.FailureResult(Error.Unauthorized(description: "Invalid username or password"));
        }

        string jwtToken = _jwtProvider.GenerateToken(user);
        Result<RefreshToken> refreshToken = await _refreshTokenRepository.CreateTokenAsync(user.Id);

        return Result<TokenResponse>
            .SuccessResult(new TokenResponse(
                jwtToken,
                refreshToken.Value!.Token
            ));
    }
}
