using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class AuthorImageFileWriteRepository : WriteRepository<AuthorImageFile>, IAuthorImageFileWriteRepository
{
    public AuthorImageFileWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
