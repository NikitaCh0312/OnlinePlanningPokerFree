using Entities;

namespace UseCases.Handlers.Game.Dtos;

public class GameStateDto
{
    public string Id { set; get; }
    
    public GameStatus Status { set; get; }
    
    public List<Player> Players { set; get; }
}