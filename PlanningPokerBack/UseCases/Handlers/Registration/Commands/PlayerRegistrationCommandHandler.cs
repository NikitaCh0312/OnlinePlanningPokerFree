using ApplicationServices.Implementations;
using ApplicationServices.Interfaces;
using MediatR;
using UseCases.Handlers.Registration.Dtos;
using Microsoft.Extensions.Options;

namespace UseCases.Handlers.Registration.Commands;

public class PlayerRegistrationCommandHandler:IRequestHandler<PlayerRegistrationCommand, PlayerRegistrationDto>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public PlayerRegistrationCommandHandler(IOptions<JwtConfiguration> configuration)
    {
        _jwtTokenGenerator = new JwtTokenGenerator(configuration.Value);
    }
    
    public Task<PlayerRegistrationDto> Handle(PlayerRegistrationCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.NewGuid().ToString("N");
        return Task.FromResult(new PlayerRegistrationDto()
        {
            Result = true,
            JwtToken = _jwtTokenGenerator.CreateAccessToken(userId, request.Nickname)
        });
    }
}