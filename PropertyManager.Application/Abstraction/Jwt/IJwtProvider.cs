// Copyright (c) Ryan Capio.
// All Rights Reserved.

using PropertyManager.Domain.Entities.Users;

namespace PropertyManager.Application.Abstraction.Jwt;

/// <summary>
/// 
/// </summary>
public interface IJwtProvider
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    string GenerateToken(User user);
}
