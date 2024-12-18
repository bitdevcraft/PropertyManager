// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Application.Abstraction.Behaviors;

public static class BehaviorResult
{
    public static TResponse CreateFailureResult<TResponse>(List<string> failures) where TResponse : Result
    {
        return (TResponse)typeof(TResponse)
            .GetMethod(nameof(Result.FailureResult), [typeof(List<string>)])
            ?.Invoke(null, [failures])!;
    }
}
