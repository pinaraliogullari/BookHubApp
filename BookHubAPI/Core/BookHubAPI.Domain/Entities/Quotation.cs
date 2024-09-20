using BookHubAPI.Domain.Common;

namespace BookHubAPI.Domain.Entities;

public class Quotation : BaseEntity
{
    public string Description { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }

}
