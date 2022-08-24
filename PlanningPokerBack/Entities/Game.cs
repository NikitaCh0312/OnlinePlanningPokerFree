namespace Entities;

public class Game
{
    public string Id { set; get; }
    
    public GameStatus Status { set; get; }
    
    public List<Player> Players { set; get; }
}