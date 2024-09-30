using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class BookFileWriteRepository : WriteRepository<BookFile>, IBookFileWriteRepository
{
    public BookFileWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
