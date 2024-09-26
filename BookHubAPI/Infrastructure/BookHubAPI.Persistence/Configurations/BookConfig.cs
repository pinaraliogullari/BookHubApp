using Bogus;
using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookHubAPI.Persistence.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.AuthorId).IsRequired();
            builder.Property(x => x.GenreId).IsRequired();
            builder.Property(x => x.Publisher).IsRequired();
            builder.Property(x => x.Publisher).HasMaxLength(50);
            builder.Property(x => x.PageCount).IsRequired();

            builder.HasOne(x => x.Author).WithMany(x => x.Books).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Genre).WithMany(x => x.Books).HasForeignKey(x => x.GenreId);

            Faker faker = new();
            builder.HasData(
                new Book
                {
                    Id = Guid.Parse("A7D8A869-2348-E9CC-9569-72288B051297"),
                    AuthorId = Guid.Parse("666E1D5C-AAAA-4EB9-BDB4-19972015DBAA"),
                    GenreId = Guid.Parse("4C61D5EA-DAED-5CC4-D386-6A2B42E01C91"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("2B451A34-FCB6-DEB4-23FD-1FC4BF0DC838"),
                    AuthorId = Guid.Parse("666E1D5C-AAAA-4EB9-BDB4-19972015DBAA"),
                    GenreId = Guid.Parse("DFF2DBDA-51AA-8664-4E8E-255A987724E8"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("53D46754-8AF1-CE26-DA9A-8310E2F14B9D"),
                    AuthorId = Guid.Parse("51956ACE-B389-8319-570A-2C73E12F28C4"),
                    GenreId = Guid.Parse("F2C351C9-DC7E-A19E-948A-CCB88A18A224"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("C318CA68-DD2E-7228-E632-FBA8F5507D43"),
                    AuthorId = Guid.Parse("39BD0599-D31D-11E7-065C-538CB686835D"),
                    GenreId = Guid.Parse("94191B24-733D-6AFA-5A61-A3A8577ACB61"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("90259CE9-87D2-BA78-FB6A-1CB6B6199220"),
                    AuthorId = Guid.Parse("5E995DD6-3888-DABE-D2CA-F43FA50564C0"),
                    GenreId = Guid.Parse("85114F80-EEDF-9DCE-9929-9ACD0A87F243"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("12EE6BF5-2ED9-7811-5E51-E3951472D9D6"),
                    AuthorId = Guid.Parse("2E2DA942-1554-3A91-D659-D797DF62DAD8"),
                    GenreId = Guid.Parse("85114F80-EEDF-9DCE-9929-9ACD0A87F243"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("51925A4D-7C5B-563D-5DFA-01EDC481B6E8"),
                    AuthorId = Guid.Parse("1A7E937C-2EE8-9A94-8349-5C0164B7BE77"),
                    GenreId = Guid.Parse("F29A9785-64CA-3773-C2D8-B884EB99CB45"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("DB229A78-0914-424B-6FED-15753A8A3AE6"),
                    AuthorId = Guid.Parse("0278A11E-AE28-EA22-9A3B-4CDBF907B16E"),
                    GenreId = Guid.Parse("6EAC7367-E35A-EF48-CE44-1CF9E831FE28"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("77696521-D742-21A3-AD7C-003CC4A0E4A4"),
                    AuthorId = Guid.Parse("1A7E937C-2EE8-9A94-8349-5C0164B7BE77"),
                    GenreId = Guid.Parse("85CD9ED6-0076-F2AB-73AD-545777B1C9BB"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                },
                new Book
                {
                    Id = Guid.Parse("A1E561DA-AADB-6E41-C890-89C9D67AB76C"),
                    AuthorId = Guid.Parse("465DD9A4-B10C-DEB7-6A52-DE987A3AD941"),
                    GenreId = Guid.Parse("DFF2DBDA-51AA-8664-4E8E-255A987724E8"),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    PublicationDate = DateTime.UtcNow.AddYears(-100),
                    Title = faker.Lorem.Sentence(1, 4),
                    Publisher = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(100, 1000)
                }


                );
        }
    }
}
