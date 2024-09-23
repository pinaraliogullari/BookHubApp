using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class QuotationReadRepository : ReadRepository<Quotation>, IQuotationReadRepository
{
    public QuotationReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
