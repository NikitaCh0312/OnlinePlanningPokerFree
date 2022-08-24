using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApplicationServices.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace ApplicationServices.Implementations;

public class JwtTokenGenerator: IJwtTokenGenerator
{
    private readonly JwtConfiguration _jwtConfiguration;
    
    public JwtTokenGenerator(JwtConfiguration configuration)
    {
        _jwtConfiguration = configuration;
    }
    
    public string CreateAccessToken(string userId, string nickname)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtClaimsTypes.Id, userId),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.Key));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var jwt = new JwtSecurityToken(
            issuer: _jwtConfiguration.Issuer,
            audience: _jwtConfiguration.Audience,
            notBefore: DateTime.Now,
            claims: claims,
            expires: DateTime.Now.Add(TimeSpan.FromDays(_jwtConfiguration.DurationDays)),
            signingCredentials: credentials);
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}