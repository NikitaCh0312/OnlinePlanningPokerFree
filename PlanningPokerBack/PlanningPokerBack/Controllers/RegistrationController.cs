using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Handlers.Registration.Commands;
using UseCases.Handlers.Registration.Dtos;

namespace PlanningPokerBack.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistrationController : ControllerBase
{
    private readonly ILogger<RegistrationController> _logger;
    private readonly IMediator _mediator;

    public RegistrationController(ILogger<RegistrationController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet("/register_create/{nickname}")]
    public async Task<GameRegistrationDto> RegisterAndCreateGame(string nickname)
    {
        return await _mediator.Send(new RegisterAndCreateGameCommand() { Nickname = nickname });
    }
    
    [HttpGet("/register_join/{nickname}/{game_id}")]
    public async Task<JoinToGameResultDto> RegisterAndJoinToGame(string nickname, string gameId)
    {
        return await _mediator.Send(new RegisterAndJoinToGameCommand() { Nickname = nickname, GameId = gameId});
    }
}