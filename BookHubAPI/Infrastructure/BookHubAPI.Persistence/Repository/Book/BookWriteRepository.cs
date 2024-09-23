using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class BookWriteRepository : WriteRepository<Book>, IBookWriteRepository
{
    public BookWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
