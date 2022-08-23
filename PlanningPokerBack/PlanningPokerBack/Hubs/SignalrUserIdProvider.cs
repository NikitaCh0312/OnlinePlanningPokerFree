using Microsoft.AspNetCore.SignalR;

namespace PlanningPokerBack.Hubs;

public class SignalrUserIdProvider : IUserIdProvider
{
    public string GetUserId(HubConnectionContext connection)
    {
        return ""; //return connection.User?.FindFirst(JwtClaimsTypes.Id)?.Value;
    }
}
