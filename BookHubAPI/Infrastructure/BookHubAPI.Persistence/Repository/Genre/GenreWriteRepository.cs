using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class GenreWriteRepository : WriteRepository<Genre>, IGenreWriteRepository
{
    public GenreWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
