using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class AuthorWriteRepository : WriteRepository<Author>, IAuthorWriteRepository
{
    public AuthorWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
