namespace BookHubAPI.Domain.Entities
{
    public class AuthorImageFile : File
    {
        public ICollection<Author> Authors { get; set; }
    }
}
