namespace ApplicationServices.Interfaces;

public interface IJwtTokenGenerator
{
    string CreateAccessToken(string userId, string nickname);
}