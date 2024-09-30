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
        private readonly IFileWriteRepository _fileWriteRepository;
        private readonly IFileReadRepository _fileReadRepository;
        private readonly IAuthorImageFileReadRepository _authorImageFileReadRepository;
        private readonly IAuthorImageFileWriteRepository _authorImageFileWriteRepository;
        private readonly IBookFileReadRepository _bookFileReadRepository;
        private readonly IBookFileWriteRepository _bookFileWriteRepository;

        public AuthorsController(
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository,
            IFileService fileService,
            IFileWriteRepository fileWriteRepository,
            IFileReadRepository fileReadRepository,
            IAuthorImageFileReadRepository authorImageFileReadRepository,
            IAuthorImageFileWriteRepository authorImageFileWriteRepository,
            IBookFileReadRepository bookFileReadRepository,
            IBookFileWriteRepository bookFileWriteRepository)
        {
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
            _fileService = fileService;
            _fileWriteRepository = fileWriteRepository;
            _fileReadRepository = fileReadRepository;
            _authorImageFileReadRepository = authorImageFileReadRepository;
            _authorImageFileWriteRepository = authorImageFileWriteRepository;
            _bookFileReadRepository = bookFileReadRepository;
            _bookFileWriteRepository = bookFileWriteRepository;
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
           var data= await _fileService.UploadAsync("resource/author-images", Request.Form.Files);
            await _authorImageFileWriteRepository.AddRangeAsync(data.Select(x => new AuthorImageFile()
            {
                FileName = x.fileName,
                Path = x.path,
            }).ToList());
            await _authorImageFileWriteRepository.SaveChangesAsync();
            return Ok();
        }
    }
}
