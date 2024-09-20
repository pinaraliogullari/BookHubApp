namespace BookHubAPI.Domain.Entities
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
