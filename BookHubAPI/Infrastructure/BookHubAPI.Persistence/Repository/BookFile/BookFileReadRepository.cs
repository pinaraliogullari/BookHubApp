using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class BookFileReadRepository : ReadRepository<BookFile>, IBookFileReadRepository
{
    public BookFileReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
