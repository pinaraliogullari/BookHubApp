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

    public IQueryable<T> GetAll()
        => Table;

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        => Table.Where(predicate);

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        => await Table.SingleOrDefaultAsync(predicate);

    public async Task<T> GetByIdAsync(string id)
        => await Table.SingleOrDefaultAsync(x => x.Id == Guid.Parse(id));


}
