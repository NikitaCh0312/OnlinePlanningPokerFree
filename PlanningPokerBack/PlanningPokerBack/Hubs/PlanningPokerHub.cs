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

    //adds player to game and broadcasts about new player
    public async Task add_player_to_game()
    {
        
    }

    public async Task remove_player_from_game()
    {
        
    }
    
    public async Task set_player_card()
    {
        
    }
    
    public async Task change_game_status()
    {
        
    }
    
    //returns state of game to caller
    public async Task get_game_state()
    {
        
    }
    
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    //removes player from game and broadcsts about player 
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}