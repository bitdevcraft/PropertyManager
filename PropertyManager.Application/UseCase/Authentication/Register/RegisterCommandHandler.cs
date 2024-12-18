using Microsoft.AspNetCore.Identity;
using PropertyManager.Application.Abstraction.Messaging;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Application.UseCase.Authentication.Register;

public class RegisterCommandHandler(UserManager<User> userManager) : ICommandHandler<RegisterCommand>
{
    public async Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = new User { UserName = request.Register.UserName, Email = request.Register.Email, };

        IdentityResult result = await userManager.CreateAsync(user, request.Register.Password);

        return !result.Succeeded
            ? Result.FailureResult("Failed to create user")
            : Result.SuccessResult();
    }
}
