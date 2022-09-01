namespace UseCases.Handlers.Registration.Dtos;

public class JoinToGameResultDto
{
    public bool Success { set; get; }
    
    public string Reason { set; get; }
    
    public string Jwt { set; get; }
}