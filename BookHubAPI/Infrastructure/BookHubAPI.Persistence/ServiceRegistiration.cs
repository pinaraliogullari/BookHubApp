using BookHubAPI.Application.Repositories;
using BookHubAPI.Persistence.Contexts;
using BookHubAPI.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Persistence;

public static class ServiceRegistiration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<BookHubDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);

        services.AddSingleton<IAuthorReadRepository, AuthorReadRepository>();
        services.AddSingleton<IAuthorWriteRepository, AuthorWriteRepository>();
        services.AddSingleton<IBookReadRepository, BookReadRepository>();
        services.AddSingleton<IBookWriteRepository, BookWriteRepository>();
        services.AddSingleton<IGenreReadRepository, GenreReadRepository>();
        services.AddSingleton<IGenreWriteRepository, GenreWriteRepository>();
        services.AddSingleton<IQuotationReadRepository, QuotationReadRepository>();
        services.AddSingleton<IQuotationWriteRepository, QuotationWriteRepository>();
        services.AddSingleton<IReviewReadRepository, ReviewReadRepository>();
        services.AddSingleton<IReviewWriteRepository, ReviewWriteRepository>();
    }
}
