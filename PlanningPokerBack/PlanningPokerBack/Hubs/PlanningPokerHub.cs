using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace PlanningPokerBack.Hubs;

public class PlanningPokerHub: Hub
{
    private readonly IMediator _mediator;
    
    public PlanningPokerHub(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}