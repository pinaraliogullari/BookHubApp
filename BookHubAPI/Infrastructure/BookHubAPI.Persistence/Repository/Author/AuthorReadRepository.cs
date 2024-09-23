using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class AuthorReadRepository : ReadRepository<Author>, IAuthorReadRepository
{
    public AuthorReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
