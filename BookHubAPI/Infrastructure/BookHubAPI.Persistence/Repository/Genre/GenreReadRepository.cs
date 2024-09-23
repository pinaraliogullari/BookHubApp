using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class GenreReadRepository : ReadRepository<Genre>, IGenreReadRepository
{
    public GenreReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
