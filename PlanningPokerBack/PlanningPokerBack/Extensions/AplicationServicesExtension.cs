using ApplicationServices.Implementations;
using ApplicationServices.Interfaces;

namespace PlanningPokerBack.Extensions;

public static class AplicationServicesExtension
{
    public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtConfiguration>(configuration.GetSection("Jwt"));
    }
}