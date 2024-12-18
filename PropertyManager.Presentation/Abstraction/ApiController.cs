using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PropertyManager.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    internal readonly ISender _sender;

    protected ApiController(ISender sender) => _sender = sender;
}
