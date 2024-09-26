using Bogus;
using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookHubAPI.Persistence.Configurations
{
    public class QuotationConfig : IEntityTypeConfiguration<Quotation>
    {
        public void Configure(EntityTypeBuilder<Quotation> builder)
        {
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.BookId).IsRequired();

            builder.HasOne(x => x.Book).WithMany(x => x.Quotation).HasForeignKey(x => x.BookId);

            Faker faker = new();
            builder.HasData(
                new Quotation
                {
                    Id = Guid.Parse("0FE05217-4BCC-B27A-D74A-7FFC3FA8BDA4"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("A7D8A869-2348-E9CC-9569-72288B051297"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("A8D817A4-88ED-85DC-D5F6-E48532C9C5E1"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("2B451A34-FCB6-DEB4-23FD-1FC4BF0DC838"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("F30B692F-34FB-2007-7977-1D7BE62BD962"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("53D46754-8AF1-CE26-DA9A-8310E2F14B9D"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("2F5D4DE3-C391-B1A4-1260-B6BFDC712040"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("C318CA68-DD2E-7228-E632-FBA8F5507D43"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("F30B692F-34FB-2007-7977-1D7BE62BD965"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("90259CE9-87D2-BA78-FB6A-1CB6B6199220"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("2F5D4DE3-C391-B1A4-1260-B6BFDC712044"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("12EE6BF5-2ED9-7811-5E51-E3951472D9D6"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("3CB7987A-567A-311C-E03B-D9C7B35552D1"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("51925A4D-7C5B-563D-5DFA-01EDC481B6E8"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("CD9EEDB3-B38E-A511-0578-9F68937E663C"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("C318CA68-DD2E-7228-E632-FBA8F5507D43"),
                    Description = faker.Lorem.Sentence(5, 20)
                },
                new Quotation
                {
                    Id = Guid.Parse("1A2853AD-CD61-6504-94D9-B7833C6ECF7C"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    BookId = Guid.Parse("A7D8A869-2348-E9CC-9569-72288B051297"),
                    Description = faker.Lorem.Sentence(5, 20)
                }
                );
        }
    }
}
