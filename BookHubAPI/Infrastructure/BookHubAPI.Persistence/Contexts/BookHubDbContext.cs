using BookHubAPI.Domain.Common;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var data = ChangeTracker.Entries<BaseEntity>();
            foreach (var item in data)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow,
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }


}
