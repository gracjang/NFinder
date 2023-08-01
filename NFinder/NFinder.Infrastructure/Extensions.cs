namespace NFinder.Infrastructure;

using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFinder.Infrastructure.Resolver;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<ICombinationResolver, CombinationResolver>();

        return services;
    }
}