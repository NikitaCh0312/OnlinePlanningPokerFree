using AutoMapper;
using MediatR;
using Storage.Interfaces;
using UseCases.Handlers.Game.Dtos;

namespace UseCases.Handlers.Game.Queries;

public class GetGameStatusQueryHandler:IRequestHandler<GetGameStatusQuery, GameStateDto>
{
    private readonly IMapper _mapper;
    private readonly IGameStorage _gameStorage;
    
    public GetGameStatusQueryHandler(IGameStorage gameStorage, IMapper mapper)
    {
        _gameStorage = gameStorage;
        _mapper = mapper;
    }
    
    public async Task<GameStateDto> Handle(GetGameStatusQuery request, CancellationToken cancellationToken)
    {
        var game = await _gameStorage.GetGameAsync(request.GameId);
        return _mapper.Map<GameStateDto>(game);
    }
}