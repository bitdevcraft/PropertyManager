using PropertyManager.Application.Abstraction.Messaging;

namespace PropertyManager.Application.UseCase.Authentication.Register;

public record RegisterCommand(
    RegisterRequest Register
) : ICommand;
