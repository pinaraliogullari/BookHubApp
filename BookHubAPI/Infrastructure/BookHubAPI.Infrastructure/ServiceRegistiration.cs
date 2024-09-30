using BookHubAPI.Application.Services;
using BookHubAPI.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Infrastructure
{
    public static class ServiceRegistiration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
