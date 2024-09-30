using BookHubAPI.Application.Repositories;
using BookHubAPI.Application.RequestParameters;
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
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AuthorsController(
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
            _webHostEnvironment = webHostEnvironment;
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
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "resource/product-images");
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            Random r = new();

            foreach (IFormFile file in Request.Form.Files)
            {
                string fullPath = Path.Combine(uploadPath, $"{r.NextDouble()}{Path.GetExtension(file.FileName)}");
                using FileStream fileStream = new(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 1024 * 1024, useAsync: false);
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
            }
            return Ok();
        }
    }
}
