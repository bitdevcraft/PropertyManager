using MediatR;
using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Application.Abstraction.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
