using PropertyManager.Application.Abstraction.Messaging;
using PropertyManager.Application.UseCase.Authentication.Login;

namespace PropertyManager.Application.UseCase.Authentication.Refresh;

public record RefreshTokenCommand(string RefreshToken) : ICommand<TokenResponse>;
