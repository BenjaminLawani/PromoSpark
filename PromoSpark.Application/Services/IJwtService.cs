using PromoSpark.Domain.Entities;
using System;
using PromoSpark.Application.Models.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Services
{
    public interface IJwtService
    {
        string GenerateToken(User user);
        ClaimsPrincipal ValidateToken(string token);
        bool IsTokenValid(string token);
        string RefreshToken(string token);
        TokenInfo GetTokenInfo(string token);
    }
}
