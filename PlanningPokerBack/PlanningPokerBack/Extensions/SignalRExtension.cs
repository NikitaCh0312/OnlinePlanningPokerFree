using Microsoft.AspNetCore.SignalR;
using PlanningPokerBack.Hubs;

namespace PlanningPokerBack.Extensions;

public static class SignalRExtension
{
    public static void AddSignalRWithAddition(this IServiceCollection services)
    {
        services.AddSingleton<IUserIdProvider, SignalrUserIdProvider>();
        services.AddSignalR();
    }
}