using PropertyManager.Domain.Common.Shared.Errors;

namespace PropertyManager.Domain.Common.Shared.Results;

public class Result<T>
{
    public bool Success { get; private set; }

    public T? Value { get; private set; }

    public List<Error> Errors { get; private set; }

    protected Result(bool success, T? value, List<Error>? errors)
    {
        Success = success;
        Value = value;
        Errors = errors ?? [];
    }

    public static Result<T> SuccessResult(T value)
    {
        return new Result<T>(true, value, null);
    }

    public static Result<T> FailureResult(List<Error> errors)
    {
        return new Result<T>(false, default, errors);
    }

    public static Result<T> FailureResult(Error error)
    {
        return FailureResult([error]);
    }
}
