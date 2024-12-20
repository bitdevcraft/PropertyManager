using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PropertyManager.Application.Abstraction.Jwt;
using PropertyManager.Application.UseCase.Authentication.Login;
using PropertyManager.Application.UseCase.Authentication.Refresh;
using PropertyManager.Application.UseCase.Authentication.Register;
using PropertyManager.Domain.Common.Repositories;
using PropertyManager.Domain.Common.Shared.Results;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Domain.Entities.Users.RefreshTokens;
using PropertyManager.Presentation.Abstraction;

namespace PropertyManager.Presentation.Controllers;

public class AuthController(
    ISender sender,
    UserManager<User> userManager,
    IJwtProvider jwtProvider,
    IRefreshTokenRepository refreshTokenRepository) : ApiController(sender)
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IRefreshTokenRepository _refreshTokenRepository = refreshTokenRepository;

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginCommand(request);
        Result<TokenResponse> result = await _sender.Send(query);

        return result.Success ? Ok(CreateUserObject(result.Value!)) : HandleErrors(result.Errors);
    }

    [HttpPost("loginV2")]
    public async Task<IActionResult> LoginV2(LoginRequest request)
    {
        User? user = await _userManager.FindByNameAsync(request.Username);

        if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
        {
            return Unauthorized("Invalid username or password");
        }

        string jwtToken = _jwtProvider.GenerateToken(user);
        Result<RefreshToken> refreshToken = await _refreshTokenRepository.CreateTokenAsync(user.Id);

        return Ok(CreateUserObject(new TokenResponse(
            jwtToken,
            refreshToken.Value!.Token
        )));
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var query = new RegisterCommand(request);
        Result result = await _sender.Send(query);

        return result.Success ? Ok() : HandleErrors(result.Errors);
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> Refresh()
    {
        string? refreshToken = Request.Cookies["token"];

        if (string.IsNullOrEmpty(refreshToken))
        {
            return BadRequest();
        }

        var query = new RefreshTokenCommand(refreshToken);
        Result<TokenResponse> result = await _sender.Send(query);

        return result.Success ? Ok(CreateUserObject(result.Value!)) : HandleErrors(result.Errors);
    }

    private void SetRefreshToken(TokenResponse tokenResponse)
    {
        var cookieOptions = new CookieOptions { HttpOnly = true, Expires = DateTime.UtcNow.AddDays(7) };

        Response.Cookies.Append("token", tokenResponse.RefreshToken!, cookieOptions);
    }

    private UserDto CreateUserObject(TokenResponse tokenResponse)
    {
        SetRefreshToken(tokenResponse);
        return new(
            "",
            tokenResponse.Token
        );
    }

    private sealed record UserDto(string UserName, string Token);
}
