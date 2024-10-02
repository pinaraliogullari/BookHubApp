using BookHubAPI.Application.Repositories;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class FileWriteRepository : WriteRepository<BookHubAPI.Domain.Entities.File>, IFileWriteRepository
{
    public FileWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
