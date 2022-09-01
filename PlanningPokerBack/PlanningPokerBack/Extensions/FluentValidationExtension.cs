using System.Reflection;
using FluentValidation;
using MediatR;
using UseCases.PipelineBehaviours;

namespace PlanningPokerBack.Extensions;

public static class FluentValidationExtension
{
    public static void AddFluentValidation(this IServiceCollection services, Assembly assembly)
    {
        services.AddValidatorsFromAssembly(assembly);
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>));
    }
}