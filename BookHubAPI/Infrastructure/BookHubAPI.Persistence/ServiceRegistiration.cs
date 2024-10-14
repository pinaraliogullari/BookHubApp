using BookHubAPI.Application.CustomValidations;
using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities.Identity;
using BookHubAPI.Persistence.Contexts;
using BookHubAPI.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookHubAPI.Persistence;

public static class ServiceRegistiration
{
    public static void AddPersistenceServices(this IServiceCollection collection)
    {
        collection.AddDbContext<BookHubDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        collection.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 4;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.User.RequireUniqueEmail = true;
        }).AddPasswordValidator<CustomPasswordValidation>().AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<BookHubDbContext>();
        collection.ConfigureApplicationCookie(options =>
        {
            options.LogoutPath = "/";
        });
        collection.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
        collection.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
        collection.AddScoped<IBookReadRepository, BookReadRepository>();
        collection.AddScoped<IBookWriteRepository, BookWriteRepository>();
        collection.AddScoped<IGenreReadRepository, GenreReadRepository>();
        collection.AddScoped<IGenreWriteRepository, GenreWriteRepository>();
        collection.AddScoped<IQuotationReadRepository, QuotationReadRepository>();
        collection.AddScoped<IQuotationWriteRepository, QuotationWriteRepository>();
        collection.AddScoped<IReviewReadRepository, ReviewReadRepository>();
        collection.AddScoped<IReviewWriteRepository, ReviewWriteRepository>();
        collection.AddScoped<IFileReadRepository, FileReadRepository>();
        collection.AddScoped<IFileWriteRepository, FileWriteRepository>();
        collection.AddScoped<IBookFileReadRepository, BookFileReadRepository>();
        collection.AddScoped<IBookFileWriteRepository, BookFileWriteRepository>();
        collection.AddScoped<IAuthorImageFileReadRepository, AuthorImageFileReadRepository>();
        collection.AddScoped<IAuthorImageFileWriteRepository, AuthorImageFileWriteRepository>();
    }
}
