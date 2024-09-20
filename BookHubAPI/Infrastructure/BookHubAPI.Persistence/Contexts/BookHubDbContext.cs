using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookHubAPI.Persistence.Contexts
{
    public class BookHubDbContext : DbContext
    {
        public BookHubDbContext(DbContextOptions<BookHubDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
