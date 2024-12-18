using PropertyManager.Application.Abstraction.Messaging;

namespace PropertyManager.Application.UseCase.Authentication.Login;

/// <summary>
/// 
/// </summary>
/// <param name="Login"></param>
public sealed record LoginCommand(LoginRequest Login)
    : ICommand<TokenResponse>;
