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
        services.AddDbContext<BookHubDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

        services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
        services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
        services.AddScoped<IBookReadRepository, BookReadRepository>();
        services.AddScoped<IBookWriteRepository, BookWriteRepository>();
        services.AddScoped<IGenreReadRepository, GenreReadRepository>();
        services.AddScoped<IGenreWriteRepository, GenreWriteRepository>();
        services.AddScoped<IQuotationReadRepository, QuotationReadRepository>();
        services.AddScoped<IQuotationWriteRepository, QuotationWriteRepository>();
        services.AddScoped<IReviewReadRepository, ReviewReadRepository>();
        services.AddScoped<IReviewWriteRepository, ReviewWriteRepository>();
        services.AddScoped<IFileReadRepository, FileReadRepository>();
        services.AddScoped<IFileWriteRepository, FileWriteRepository>();
        services.AddScoped<IBookFileReadRepository, BookFileReadRepository>();
        services.AddScoped<IBookFileWriteRepository, BookFileWriteRepository>();
        services.AddScoped<IAuthorImageFileReadRepository, AuthorImageFileReadRepository>();
        services.AddScoped<IAuthorImageFileWriteRepository, AuthorImageFileWriteRepository>();
    }
}
