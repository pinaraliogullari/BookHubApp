using BookHubAPI.Domain.Common;
using System.Linq.Expressions;

namespace BookHubAPI.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(string id);
}
