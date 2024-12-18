using MediatR;
using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Application.Abstraction.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
