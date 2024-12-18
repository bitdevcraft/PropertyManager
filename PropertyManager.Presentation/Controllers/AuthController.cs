using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyManager.Application.UseCase.Authentication.Login;
using PropertyManager.Application.UseCase.Authentication.Refresh;
using PropertyManager.Application.UseCase.Authentication.Register;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Presentation.Abstraction;

namespace PropertyManager.Presentation.Controllers;

public class AuthController(ISender sender) : ApiController(sender)
{
    [HttpPost("login")]
    public async Task<ActionResult<TokenResponse>> Login(LoginRequest request)
    {
        var query = new LoginCommand(request);
        Result<TokenResponse> result = await _sender.Send(query);

        SetRefreshToken(result.Value!);

        return result.Success ? Ok(result.Value!.Token) : BadRequest(result.Errors);
    }

    [HttpPost("register")]
    public async Task<ActionResult<TokenResponse>> Register(RegisterRequest request)
    {
        var query = new RegisterCommand(request);
        Result result = await _sender.Send(query);

        return result.Success ? Ok() : BadRequest(result.Errors);
    }

    [HttpPost("refresh-token")]
    public async Task<ActionResult<TokenResponse>> Refresh()
    {
        string? refreshToken = Request.Cookies["token"];

        if (string.IsNullOrEmpty(refreshToken))
        {
            return BadRequest();
        }

        var query = new RefreshTokenCommand(refreshToken);
        Result<TokenResponse> result = await _sender.Send(query);

        SetRefreshToken(result.Value!);

        return result.Success ? Ok(result.Value!.Token) : BadRequest(result.Errors);
    }

    private void SetRefreshToken(TokenResponse tokenResponse)
    {
        var cookieOptions = new CookieOptions { HttpOnly = true, Expires = DateTime.UtcNow.AddDays(7) };

        Response.Cookies.Append("token", tokenResponse.RefreshToken!, cookieOptions);
    }
}
