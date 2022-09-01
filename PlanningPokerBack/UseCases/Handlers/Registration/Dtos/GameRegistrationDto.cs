namespace UseCases.Handlers.Registration.Dtos;

public class GameRegistrationDto
{
    public bool Success { set; get; }
    
    public string Reason { set; get; }
    
    public string GameId { set; get; }
    
    public string JwtToken { set; get; }
}