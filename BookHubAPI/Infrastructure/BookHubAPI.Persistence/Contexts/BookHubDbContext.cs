using BookHubAPI.Domain.Common;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using File = BookHubAPI.Domain.Entities.File;

namespace BookHubAPI.Persistence.Contexts
{
    public class BookHubDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public BookHubDbContext(DbContextOptions<BookHubDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<BookFile> BookFiles { get; set; }
        public DbSet<AuthorImageFile> AuthorImageFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
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
