using AntiCheatService.Application.Interfaces;
using AntiCheatService.Domain.Interfaces;
using AntiCheatService.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AntiCheatService.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IPlayerRepository, PlayerRepository>();
    }
}