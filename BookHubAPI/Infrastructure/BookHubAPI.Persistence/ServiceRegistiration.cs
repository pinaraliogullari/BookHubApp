using BookHubAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BookHubAPI.Persistence;

public static class ServiceRegistiration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<BookHubDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=BookHubDb;"));
    }
}
