using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PlanningPokerBack.Hubs;
using UseCases.Handlers.Registration.Commands;
using UseCases.Handlers.Registration.Dtos;

namespace PlanningPokerBack.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistrationController : ControllerBase
{
    private readonly ILogger<RegistrationController> _logger;
    private readonly IHubContext<PlanningPokerHub> _hubContext;
    private readonly IMediator _mediator;

    public RegistrationController(ILogger<RegistrationController> logger,
        IMediator mediator,
        IHubContext<PlanningPokerHub> hubContext)
    {
        _logger = logger;
        _mediator = mediator;
        _hubContext = hubContext;
    }

    [HttpGet("/register_create/{nickname}")]
    public async Task<GameRegistrationDto> RegisterAndCreateGame(string nickname)
    {
        return await _mediator.Send(new RegisterAndCreateGameCommand() { Nickname = nickname });
    }
    
    [HttpGet("/register_join/{nickname}/{gameId}")]
    public async Task<JoinToGameResultDto> RegisterAndJoinToGame(string nickname, string gameId)
    {
        return await _mediator.Send(new RegisterAndJoinToGameCommand() { Nickname = nickname, GameId = gameId});
    }
}