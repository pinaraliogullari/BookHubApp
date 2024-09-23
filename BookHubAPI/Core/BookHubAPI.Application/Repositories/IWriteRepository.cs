using BookHubAPI.Domain.Common;

namespace BookHubAPI.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddAsync(List<T> model);
    Task<bool> Remove(T model);
    Task<bool> Remove(string id);
    Task<bool> Update(T model);
}
