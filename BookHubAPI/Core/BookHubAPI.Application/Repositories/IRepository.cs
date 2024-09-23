using BookHubAPI.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace BookHubAPI.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}
