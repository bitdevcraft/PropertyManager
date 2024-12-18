﻿namespace PropertyManager.Infrastructure.Security.Jwt;

public class JwtOptions
{
    public const string Section = "Jwt";
    public string Issuer { get; init; } = null!;
    public string Audience { get; init; } = null!;
    public string SecretKey { get; init; } = null!;
}
