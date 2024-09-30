using BookHubAPI.Application.Repositories;
using BookHubAPI.Application.RequestParameters;
using BookHubAPI.Application.Services;
using BookHubAPI.Application.ViewModels.Author;
using BookHubAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookHubAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IFileService _fileService;

        public AuthorsController(
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository,
            IFileService fileService)
        {
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Pagination pagination)
        {
            await Task.Delay(1000);
            var totalCount = _authorReadRepository.GetAll(false).Count();
            var authors = _authorReadRepository.GetAll(false).Select(x => new
            {
                x.Id,
                x.CreatedDate,
                x.UpdatedDate,
                x.FirstName,
                x.LastName
            }).Skip(pagination.Page * pagination.Size).Take(pagination.Size).ToList();
            return Ok(new
            {
                authors,
                totalCount
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _authorReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateAuthorVM model)
        {

            await _authorWriteRepository.AddAsync(new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
            });
            await _authorWriteRepository.SaveChangesAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(UpdateAuthorVM model)
        {
            Author author = await _authorReadRepository.GetByIdAsync(model.Id);
            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            await _authorWriteRepository.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _authorWriteRepository.RemoveAsync(id);
            await _authorWriteRepository.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            await _fileService.UploadAsync("resource/product-images", Request.Form.Files);
            return Ok();
        }
    }
}
