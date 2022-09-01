using AutoMapper;
using Entities;
using UseCases.Handlers.Game.Dtos;

namespace UseCases.Handlers.Game.Mappings;

public class GameMapperProfile:Profile
{
    public GameMapperProfile()
    {
        CreateMap<Entities.Game, GameStateDto>();
    }
}