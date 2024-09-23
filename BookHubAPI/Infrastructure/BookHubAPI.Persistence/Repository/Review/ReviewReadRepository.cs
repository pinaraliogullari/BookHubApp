using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class ReviewReadRepository : ReadRepository<Review>, IReviewReadRepository
{
    public ReviewReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
