using BookHubAPI.Domain.Common;

namespace BookHubAPI.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Guid GenreId { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public DateTime PublicationDate { get; set; }
        public ICollection<Quotation> Quotation { get; set; }
        public ICollection<Review> Reviews { get; set; }


    }
}
