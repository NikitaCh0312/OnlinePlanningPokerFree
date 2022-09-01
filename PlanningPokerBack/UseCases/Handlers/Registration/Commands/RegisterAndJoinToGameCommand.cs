using MediatR;
using UseCases.Handlers.Registration.Dtos;

namespace UseCases.Handlers.Registration.Commands;

public class RegisterAndJoinToGameCommand: IRequest<JoinToGameResultDto>
{
    public string Nickname { set; get; }
    
    public string GameId { set; get; }
}