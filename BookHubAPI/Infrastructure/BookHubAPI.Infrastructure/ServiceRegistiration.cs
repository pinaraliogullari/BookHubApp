using BookHubAPI.Application.Abstractions.Storage;
using BookHubAPI.Infrastructure.Enums;
using BookHubAPI.Infrastructure.Services.Storage;
using BookHubAPI.Infrastructure.Services.Storage.Local;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Infrastructure;

public static class ServiceRegistiration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IStorageService, StorageService>();
    }
    public static void AddStorage<T>(this IServiceCollection services) where T : class, IStorage
    {
        services.AddScoped<IStorage, T>();
    }
    public static void AddStorage(this IServiceCollection services,StorageType storageType) 
    {
        switch (storageType)
        {
            case StorageType.Local:
                services.AddScoped<IStorage, LocalStorage>();
                break;
            case StorageType.Azure:
                break;
            case StorageType.AWS:
                break;
            default:
                services.AddScoped<IStorage, LocalStorage>();
                break;
        }
    }
}
