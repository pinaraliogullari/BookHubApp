using BookHubAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookHubAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookHubDbContext>
{
    public BookHubDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BookHubDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=BookHubDb;");
        return new(dbContextOptionsBuilder.Options);
    }
}
