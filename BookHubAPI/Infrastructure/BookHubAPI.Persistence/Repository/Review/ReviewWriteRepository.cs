using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class ReviewWriteRepository : WriteRepository<Review>, IReviewWriteRepository
{
    public ReviewWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
