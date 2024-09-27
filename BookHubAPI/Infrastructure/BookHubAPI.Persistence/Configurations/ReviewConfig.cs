using Bogus;
using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookHubAPI.Persistence.Configurations
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.BookId).IsRequired();

            builder.HasOne(x => x.Book).WithMany(x => x.Reviews).HasForeignKey(x => x.BookId);

            Faker faker = new();
            builder.HasData(
                new Review
                {
                    Id = Guid.Parse("60F6C9E4-14CF-42B9-7708-1B7D0974BA26"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("A7D8A869-2348-E9CC-9569-72288B051297"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("BE36E34D-FBB8-9B46-E9AD-B4A820E55016"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("2B451A34-FCB6-DEB4-23FD-1FC4BF0DC838"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("1AFC5BE6-B111-FAB7-0CC9-757D3154ADB3"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("2B451A34-FCB6-DEB4-23FD-1FC4BF0DC838"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("E8D2A2DA-CD9E-F299-202C-B6ED9E1F94D7"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("53D46754-8AF1-CE26-DA9A-8310E2F14B9D"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("EDC531DE-3491-3EE9-7992-4BE730EAD84E"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("C318CA68-DD2E-7228-E632-FBA8F5507D43"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("D4E14BE6-DA76-444A-9C51-4CAD6CA4A466"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("90259CE9-87D2-BA78-FB6A-1CB6B6199220"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("0665CD7B-17F4-9387-E3EC-0A9F7EC0C15B"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("90259CE9-87D2-BA78-FB6A-1CB6B6199220"),
                    Description = faker.Lorem.Sentence(5, 30)
                },
                new Review
                {
                    Id = Guid.Parse("274772B7-A644-4C41-7D38-0569AC273E65"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("12EE6BF5-2ED9-7811-5E51-E3951472D9D6"),
                    Description = faker.Lorem.Sentence(5, 30)
                }
                );



        }
    }
}
