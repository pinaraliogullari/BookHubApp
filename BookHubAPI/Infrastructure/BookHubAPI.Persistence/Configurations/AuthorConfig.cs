using Bogus;
using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookHubAPI.Persistence.Configurations;

public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(x => x.FirstName).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(20);
        builder.Property(x => x.LastName).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(20);

        Faker faker = new();
        builder.HasData(
            new
            {
                Id = Guid.Parse("666E1D5C-AAAA-4EB9-BDB4-19972015DBAA"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("51956ACE-B389-8319-570A-2C73E12F28C4"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("39BD0599-D31D-11E7-065C-538CB686835D"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("5E995DD6-3888-DABE-D2CA-F43FA50564C0"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("2E2DA942-1554-3A91-D659-D797DF62DAD8"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("1A7E937C-2EE8-9A94-8349-5C0164B7BE77"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("0278A11E-AE28-EA22-9A3B-4CDBF907B16E"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("465DD9A4-B10C-DEB7-6A52-DE987A3AD941"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("33FD486F-34B7-A460-9984-A6869E834E31"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            },
            new
            {
                Id = Guid.Parse("B569D1DC-DF67-8268-FB3C-E2AB1751B62C"),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName()
            }

            );

    }
}
