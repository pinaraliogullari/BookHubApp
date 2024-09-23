using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Common;
using BookHubAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookHubAPI.Persistence.Repository;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly BookHubDbContext _context;

    public WriteRepository(BookHubDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table =>_context.Set<T>();

    public Task<bool> AddAsync(T model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddAsync(List<T> model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Remove(T model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Remove(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(T model)
    {
        throw new NotImplementedException();
    }
}
