using Storage.Implementations;
using Storage.Interfaces;

namespace PlanningPokerBack.Extensions;

public static class InfrastructureExtension
{
    public static void AddApplicationInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IGameStorage, GameStorage>();
    }
}