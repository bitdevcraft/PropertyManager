using MediatR;
using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Application.Abstraction.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
