using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Common;
using BookHubAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookHubAPI.Persistence.Repository;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly BookHubDbContext _context;

    public WriteRepository(BookHubDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> data)
    {
        await Table.AddRangeAsync(data);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;

    }

    public async Task<bool> RemoveAsync(string id)
    {
        var model = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        return Remove(model);

        //EntityEntry<T> entityEntry = Table.Remove(deletedEntity);
        //return entityEntry.State == EntityState.Deleted;
    }
    public bool RemoveRange(List<T> data)
    {
        Table.RemoveRange(data);
        return true;
    }

    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveChangesAsync()
    => await _context.SaveChangesAsync();


}
