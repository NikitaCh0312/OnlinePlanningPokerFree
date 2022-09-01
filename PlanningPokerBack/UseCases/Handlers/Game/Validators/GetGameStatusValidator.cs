using FluentValidation;
using UseCases.Handlers.Game.Queries;

namespace UseCases.Handlers.Game.Validators;

public class GetGameStatusValidator:AbstractValidator<GetGameStatusQuery>
{
    public GetGameStatusValidator()
    {
        RuleFor(x => x.GameId).NotNull().NotEmpty();
    }
}