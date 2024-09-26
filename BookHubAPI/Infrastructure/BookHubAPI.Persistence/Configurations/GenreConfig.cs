using BookHubAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookHubAPI.Persistence.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasData(
                 new Genre
                 {
                     Id = Guid.Parse("DFF2DBDA-51AA-8664-4E8E-255A987724E8"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Poetry "
                 },
                 new Genre
                 {
                     Id = Guid.Parse("85CD9ED6-0076-F2AB-73AD-545777B1C9BB"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Fantasy"
                 },
                 new Genre
                 {
                     Id = Guid.Parse("4C61D5EA-DAED-5CC4-D386-6A2B42E01C91"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Fiction"
                 },
                 new Genre
                 {
                     Id = Guid.Parse("6EAC7367-E35A-EF48-CE44-1CF9E831FE28"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Biography"
                 },
                 new Genre
                 {
                     Id = Guid.Parse("F29A9785-64CA-3773-C2D8-B884EB99CB45"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "History"
                 },
                 new Genre
                 {
                     Id = Guid.Parse("46A9821B-3DEE-F394-B52D-E3936C3915E1"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Romance"
                 },
                 new Genre
                 {
                     Id = Guid.Parse("D43C4A6A-2C38-8336-3B17-8E257ECFE3ED"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Psychology "
                 },
                 new Genre
                 {
                     Id = Guid.Parse("F2C351C9-DC7E-A19E-948A-CCB88A18A224"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Fairytale "
                 },
                 new Genre
                 {
                     Id = Guid.Parse("94191B24-733D-6AFA-5A61-A3A8577ACB61"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Self-Help "
                 },
                 new Genre
                 {
                     Id = Guid.Parse("85114F80-EEDF-9DCE-9929-9ACD0A87F243"),
                     CreatedDate = DateTime.UtcNow,
                     UpdatedDate = DateTime.UtcNow,
                     Name = "Science "
                 }
                );
        }
    }
}
