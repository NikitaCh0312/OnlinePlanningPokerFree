using MediatR;
using UseCases.Handlers.Registration.Dtos;

namespace UseCases.Handlers.Registration.Commands;

public class RegisterAndCreateGameCommand: IRequest<GameRegistrationDto>
{
    public string Nickname { set; get; }
}