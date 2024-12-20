using MediatR;
using PropertyManager.Domain.Common.Shared.Errors;

namespace PropertyManager.Domain.Common.Shared.Results;

public class Result : Result<Unit>
{
    // Constructor to initialize Result with Unit type (no value)
    private Result(bool success, List<Error>? errors)
        : base(success, Unit.Value, errors)
    {
    }

    // Factory method for success result
    public static Result SuccessResult()
    {
        return new Result(true, null);
    }

    // Factory method for failure result with a list of errors
    public new static Result FailureResult(List<Error> errors)
    {
        return new Result(false, errors);
    }

    // Factory method for failure result with a single error message
    public new static Result FailureResult(Error error)
    {
        return FailureResult([error]);
    }

    public new static Result FailureResult(List<string> errors)
    {
        var errorList = errors
            .Select(error =>
                Error.Validation(description: error))
            .ToList();
        
        return FailureResult(errorList);
    }
}
