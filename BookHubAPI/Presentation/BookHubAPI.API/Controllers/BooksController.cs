using BookHubAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookHubAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IBookWriteRepository _bookWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;

        public BooksController(IBookReadRepository bookReadRepository, IBookWriteRepository bookWriteRepository, IAuthorReadRepository authorReadRepository, IAuthorWriteRepository authorWriteRepository)
        {
            _bookReadRepository = bookReadRepository;
            _bookWriteRepository = bookWriteRepository;
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
        }

        [HttpGet]
        public async void Get()
        {
            await _authorWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,FirstName="abc",LastName="xyz"},
                new(){Id=Guid.NewGuid(), CreatedDate=DateTime.UtcNow,FirstName="klm",LastName="pnr"},
            });
            var count = await _bookWriteRepository.SaveChangesAsync();
        }
    }
}
