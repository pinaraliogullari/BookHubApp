using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Common;
using BookHubAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookHubAPI.Persistence.Repository;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly BookHubDbContext _context;

    public ReadRepository(BookHubDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        var query = Table.Where(predicate).AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;

    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return await query.SingleOrDefaultAsync(predicate);
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return await query.SingleOrDefaultAsync(x => x.Id == Guid.Parse(id));
        // await Table.FindAsync(Guid.Parse(id));
    }



}
