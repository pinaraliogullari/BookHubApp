using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class BookReadRepository : ReadRepository<Book>, IBookReadRepository
{
    public BookReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
