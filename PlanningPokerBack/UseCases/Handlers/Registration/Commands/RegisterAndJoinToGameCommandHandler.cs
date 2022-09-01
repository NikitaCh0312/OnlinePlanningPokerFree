using ApplicationServices.Implementations;
using ApplicationServices.Interfaces;
using Entities;
using MediatR;
using Microsoft.Extensions.Options;
using Storage.Interfaces;
using UseCases.Handlers.Registration.Dtos;

namespace UseCases.Handlers.Registration.Commands;

public class RegisterAndJoinToGameCommandHandler:IRequestHandler<RegisterAndJoinToGameCommand, JoinToGameResultDto>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IGameStorage _gameStorage;
    
    public RegisterAndJoinToGameCommandHandler(IOptions<JwtConfiguration> configuration,
                                    IGameStorage gameStorage)
    {
        _jwtTokenGenerator = new JwtTokenGenerator(configuration.Value);
        _gameStorage = gameStorage;
    }
    
    public async Task<JoinToGameResultDto> Handle(RegisterAndJoinToGameCommand request, CancellationToken cancellationToken)
    {
        var game = await _gameStorage.GetGameAsync(request.GameId);
        if (game == null)
            return new JoinToGameResultDto()
            {
                Success = false,
                Reason = "no such game found",
                Jwt = null,
            };
        
        Player player = new Player()
        {
            Id = Guid.NewGuid().ToString("N"),
            Nickname = request.Nickname
        };
        game.Players.Add(player);

        await _gameStorage.UpdateGameAsync(game);
        
        return new JoinToGameResultDto()
        {
            Success = true,
            Reason = "connected to game",
            Jwt = _jwtTokenGenerator.CreateAccessToken(player.Id, player.Nickname),
        };
    }
}