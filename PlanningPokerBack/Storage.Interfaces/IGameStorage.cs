using Entities;

namespace Storage.Interfaces;

public interface IGameStorage
{
    Task<Game?> GetGameAsync(string id);

    Task AddGameAsync(Game game);

    Task UpdateGameAsync(Game game);
}