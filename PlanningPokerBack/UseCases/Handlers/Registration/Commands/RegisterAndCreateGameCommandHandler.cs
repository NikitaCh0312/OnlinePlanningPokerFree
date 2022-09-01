using ApplicationServices.Implementations;
using ApplicationServices.Interfaces;
using Entities;
using MediatR;
using UseCases.Handlers.Registration.Dtos;
using Microsoft.Extensions.Options;
using Storage.Interfaces;

namespace UseCases.Handlers.Registration.Commands;

public class RegisterAndCreateGameCommandHandler:IRequestHandler<RegisterAndCreateGameCommand, GameRegistrationDto>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IGameStorage _gameStorage;
    
    public RegisterAndCreateGameCommandHandler(IOptions<JwtConfiguration> configuration,
                                            IGameStorage gameStorage)
    {
        _jwtTokenGenerator = new JwtTokenGenerator(configuration.Value);
        _gameStorage = gameStorage;
    }
    
    public async Task<GameRegistrationDto> Handle(RegisterAndCreateGameCommand request, CancellationToken cancellationToken)
    {
        Entities.Game game = new Entities.Game()
        {
            Id = Guid.NewGuid().ToString("N"),
            Status = GameStatus.Iddle,
        };
        Player player = new Player()
        {
            Id = Guid.NewGuid().ToString("N"),
            Nickname = request.Nickname
        };
        game.Players.Add(player);
        await _gameStorage.AddGameAsync(game);
        
        return new GameRegistrationDto()
        {
            Result = true,
            JwtToken = _jwtTokenGenerator.CreateAccessToken(player.Id, player.Nickname)
        };
    }
}