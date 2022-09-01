using MediatR;
using UseCases.Handlers.Game.Dtos;

namespace UseCases.Handlers.Game.Queries;

public class GetGameStatusQuery: IRequest<GameStateDto>
{
    public string GameId { set; get; }
}