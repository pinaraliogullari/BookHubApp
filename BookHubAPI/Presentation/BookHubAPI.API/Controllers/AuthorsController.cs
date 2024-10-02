using BookHubAPI.Application.Abstractions.Storage;
using BookHubAPI.Application.Repositories;
using BookHubAPI.Application.RequestParameters;
using BookHubAPI.Application.ViewModels.Author;
using BookHubAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Http.Headers;

namespace BookHubAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IFileWriteRepository _fileWriteRepository;
        private readonly IFileReadRepository _fileReadRepository;
        private readonly IAuthorImageFileReadRepository _authorImageFileReadRepository;
        private readonly IAuthorImageFileWriteRepository _authorImageFileWriteRepository;
        private readonly IBookFileReadRepository _bookFileReadRepository;
        private readonly IBookFileWriteRepository _bookFileWriteRepository;
        private readonly IStorageService _storageService;
        private readonly IConfiguration _configuration;

        public AuthorsController(
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository,
            IFileWriteRepository fileWriteRepository,
            IFileReadRepository fileReadRepository,
            IAuthorImageFileReadRepository authorImageFileReadRepository,
            IAuthorImageFileWriteRepository authorImageFileWriteRepository,
            IBookFileReadRepository bookFileReadRepository,
            IBookFileWriteRepository bookFileWriteRepository,
            IStorageService storageService,
            IConfiguration configuration)
        {
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
            _fileWriteRepository = fileWriteRepository;
            _fileReadRepository = fileReadRepository;
            _authorImageFileReadRepository = authorImageFileReadRepository;
            _authorImageFileWriteRepository = authorImageFileWriteRepository;
            _bookFileReadRepository = bookFileReadRepository;
            _bookFileWriteRepository = bookFileWriteRepository;
            _storageService = storageService;
            _configuration = configuration;
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
        public async Task<IActionResult> Upload(string id)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("images", Request.Form.Files);
            Author author= await _authorReadRepository.GetByIdAsync(id);
            await _authorImageFileWriteRepository.AddRangeAsync(result.Select(x => new AuthorImageFile
            {
                FileName = x.fileName,
                Path = x.pathOrContainerName,
                Storage=_storageService.StorageName,
                Authors= new List<Author>() { author}
            }).ToList());
            await _authorImageFileWriteRepository.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetImages(string id)
        {
            Author? author= await _authorReadRepository.Table.Include(x=>x.AuthorImageFiles).FirstOrDefaultAsync(x=>x.Id==Guid.Parse(id));
            return Ok(author.AuthorImageFiles.Select(x => new
            {
                Path= $"{_configuration["BaseStorageUrl"]}/{x.Path}",
                x.FileName
            }));
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Delete(string id, string imageId)
        {
            Author? author = await _authorReadRepository.Table.Include(x => x.AuthorImageFiles).FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

            AuthorImageFile authorImageFile= author.AuthorImageFiles.FirstOrDefault(x=>x.Id==Guid.Parse(imageId));
            author.AuthorImageFiles.Remove(authorImageFile);
            await _authorWriteRepository.SaveChangesAsync();
            return Ok();
        }
    }
}
