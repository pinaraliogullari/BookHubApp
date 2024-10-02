using BookHubAPI.Application.Repositories;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class FileReadRepository : ReadRepository<BookHubAPI.Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
