using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Http.Connections;
using PlanningPokerBack.Extensions;
using PlanningPokerBack.Hubs;
using UseCases.Handlers.Registration.Commands;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder.Services, builder.Configuration);
builder.WebHost.UseUrls("http://0.0.0.0:5000");

var app = builder.Build();
Configure(app).Run();


void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddJwtAuthentication(configuration);
    services.AddCacheStorage(configuration);
    
    var useCasesAssembly = typeof(RegisterAndCreateGameCommandHandler).GetTypeInfo().Assembly;
    services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddSignalRWithAddition();
    services.AddCors();
    services.AddMediatR(useCasesAssembly);
    
}

WebApplication Configure(WebApplication app)
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseRouting();
    app.UseCors(builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");
        endpoints.MapHub<PlanningPokerHub>("/planning_poker", options =>
        {
            options.ApplicationMaxBufferSize = 64;
            options.TransportMaxBufferSize = 64;
            options.Transports = HttpTransportType.WebSockets;
        });
    });

    return app;
}
