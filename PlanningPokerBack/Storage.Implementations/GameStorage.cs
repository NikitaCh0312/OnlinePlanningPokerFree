using Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Storage.Interfaces;

namespace Storage.Implementations;

public class GameStorage:IGameStorage
{
    private readonly IDistributedCache _cache;
    public GameStorage(IDistributedCache cache)
    {
        _cache = cache;
    }
    
    public async Task<Game?> GetGameAsync(string id)
    {
        var game = await _cache.GetStringAsync(id);
        if (game == null)
            return null;
        return JsonConvert.DeserializeObject<Game>(game);
    }

    public async Task AddGameAsync(Game game)
    {
        var options = new DistributedCacheEntryOptions()
        {
            SlidingExpiration = TimeSpan.FromHours(2)
        };
        await _cache.SetStringAsync(game.Id, JsonConvert.SerializeObject(game), options);
    }

    public async Task UpdateGameAsync(Game game)
    {
        await _cache.RemoveAsync(game.Id);
        await AddGameAsync(game);
    }
}