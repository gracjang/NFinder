namespace NFinder.Application;

using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NFinder.Application.Channels;
using NFinder.Application.Handlers;

public static class Extensions
{
    public static IServiceCollection AddApplicationInfrastructure(IServiceCollection services)
    {
        services.AddSingleton<JobChannel>();
        services.AddMediatR(typeof(GetProcessingJobsHandler));

        return services;
    }
}