using MediatR;
using UseCases.Handlers.Registration.Dtos;

namespace UseCases.Handlers.Registration.Commands;

public class PlayerRegistrationCommand: IRequest<PlayerRegistrationDto>
{
    public string Nickname { set; get; }
}