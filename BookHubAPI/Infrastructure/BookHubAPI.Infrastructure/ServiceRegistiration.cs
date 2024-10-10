using BookHubAPI.Application.Abstractions.Storage;
using BookHubAPI.Application.Abstractions.Token;
using BookHubAPI.Infrastructure.Enums;
using BookHubAPI.Infrastructure.Services.Storage;
using BookHubAPI.Infrastructure.Services.Storage.Azure;
using BookHubAPI.Infrastructure.Services.Storage.Local;
using BookHubAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Infrastructure;

public static class ServiceRegistiration
{
    public static void AddInfrastructureServices(this IServiceCollection collection)
    {
        collection.AddScoped<IStorageService, StorageService>();
        collection.AddScoped<ITokenHandler,TokenHandler>();
    }
    public static void AddStorage<T>(this IServiceCollection collection) where T : Storage, IStorage
    {
        collection.AddScoped<IStorage, T>();
    }
    public static void AddStorage(this IServiceCollection collection, StorageType storageType)
    {
        switch (storageType)
        {
            case StorageType.Local:
                collection.AddScoped<IStorage, LocalStorage>();
                break;
            case StorageType.Azure:
                collection.AddScoped<IStorage, AzureStorage>();
                break;
            case StorageType.AWS:
                break;
            default:
                collection.AddScoped<IStorage, LocalStorage>();
                break;
        }
    }
}
