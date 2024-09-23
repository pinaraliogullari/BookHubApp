using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;

namespace BookHubAPI.Persistence.Repository;

public class QuotationWriteRepository : WriteRepository<Quotation>, IQuotationWriteRepository
{
    public QuotationWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
