using BookHubAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookHubAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookHubDbContext>
{
    public BookHubDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BookHubDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}
