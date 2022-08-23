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

    [HttpGet("{nickname}")]
    public async Task<PlayerRegistrationDto> Authorize(string nickname)
    {
        return await _mediator.Send(new PlayerRegistrationCommand() { Nickname = nickname });
    }
}