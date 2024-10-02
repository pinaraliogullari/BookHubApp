using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class AuthorImageFileReadRepository : ReadRepository<AuthorImageFile>, IAuthorImageFileReadRepository
{
    public AuthorImageFileReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
