using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyManager.Domain.Common.Shared.Errors;
using PropertyManager.Domain.Common.Shared.Results;

namespace PropertyManager.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    internal readonly ISender _sender;

    protected ApiController(ISender sender) => _sender = sender;

    public IActionResult HandleFailure(Result result)
    {
        List<Error> errors = result.Errors;

        return HandleErrors(errors);
    }

    public IActionResult HandleFailure<T>(Result<T> result)
    {
        List<Error> errors = result.Errors;

        return HandleErrors(errors);
    }

    public IActionResult HandleErrors(List<Error>? errors)
    {
        return errors is null || errors.Count == 0
            ? throw new InvalidOperationException()
            : (errors.Count switch
            {
                1 => IdentifyFailure(errors[0]),
                > 1 => BadRequest(
                    CreateProblemDetails(
                        "Bad Request",
                        StatusCodes.Status400BadRequest,
                        Error.None(),
                        errors.Select(error => error.Description).ToArray()
                    )
                ),
                _
                    => BadRequest(
                        CreateProblemDetails(
                            "Internal Server Error",
                            StatusCodes.Status500InternalServerError,
                            errors[0]
                        )
                    )
            });
    }

    private IActionResult IdentifyFailure(Error error)
    {
        return error.Type switch
        {
            ErrorType.Conflict =>
                Conflict(CreateProblemDetails(
                    "Bad Request",
                    StatusCodes.Status409Conflict,
                    error
                )),
            ErrorType.Unauthorized =>
                Unauthorized(CreateProblemDetails(
                    "Bad Request",
                    StatusCodes.Status401Unauthorized,
                    error
                )),
            ErrorType.NotFound =>
                NotFound(CreateProblemDetails(
                    "Bad Request",
                    StatusCodes.Status404NotFound,
                    error
                )),
            ErrorType.Validation
                or ErrorType.None
                or ErrorType.Failure
                or ErrorType.Unexpected
                or ErrorType.Forbidden
                => BadRequest(CreateProblemDetails(
                    "Bad Request",
                    StatusCodes.Status400BadRequest,
                    error
                )),
            _ => BadRequest(CreateProblemDetails(
                "Internal Server Error",
                StatusCodes.Status500InternalServerError,
                error
            ))
        };
    }

    private static ProblemDetails CreateProblemDetails(
        string title,
        int status,
        Error error,
        string[]? errors = null
    )
        => new()
        {
            Title = title,
            Type = error.Code,
            Detail = error.Description,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };
}
