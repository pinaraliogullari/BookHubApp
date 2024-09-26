using BookHubAPI.Domain.Common;

namespace BookHubAPI.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string Description { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
