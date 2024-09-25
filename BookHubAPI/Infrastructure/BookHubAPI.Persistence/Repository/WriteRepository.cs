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
        bool isAdd= entityEntry.State == EntityState.Added;
        return isAdd;
    }

    public async Task<bool> AddRangeAsync(List<T> data)
    {
        await Table.AddRangeAsync(data);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        bool isRemove= entityEntry.State == EntityState.Deleted;
        return isRemove;

    }

    public async Task<bool> RemoveAsync(string id)
    {
        var model = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        bool isRemove = Remove(model);
        return isRemove;

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
        bool isUpdate = entityEntry.State == EntityState.Modified;
        return isUpdate;
    }

    public async Task<int> SaveChangesAsync()
    => await _context.SaveChangesAsync();


}
