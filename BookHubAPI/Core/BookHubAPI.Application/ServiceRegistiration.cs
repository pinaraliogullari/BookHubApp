using BookHubAPI.Application.Mapping;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Application
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistiration));
            collection.AddAutoMapper(typeof(AuthorMapping));
        }
    }
}
