using MediatR;
using UseCases.Handlers.Registration.Dtos;

namespace UseCases.Handlers.Registration.Commands;

public class PlayerRegistrationCommandHandler:IRequestHandler<PlayerRegistrationCommand, PlayerRegistrationDto>
{
    public Task<PlayerRegistrationDto> Handle(PlayerRegistrationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}