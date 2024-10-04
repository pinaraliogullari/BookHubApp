using BookHubAPI.Application.Features.Commands.Author.CreateAuthor;
using BookHubAPI.Application.Features.Commands.Author.RemoveAuthor;
using BookHubAPI.Application.Features.Commands.Author.UpdateAuthor;
using BookHubAPI.Application.Features.Commands.AuthorImageFile.RemoveAuthorImage;
using BookHubAPI.Application.Features.Commands.AuthorImageFile.UploadAuthorImage;
using BookHubAPI.Application.Features.Queires.Author.GetAllAuthor;
using BookHubAPI.Application.Features.Queires.Author.GetByIdAuthor;
using BookHubAPI.Application.Features.Queires.AuthorImageFile.GetAuthorImages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookHubAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllAuthorQueryRequest request)
        {
            GetAllAuthorQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdAuthorQueryRequest request)
        {
            GetByIdAuthorQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAuthorCommandRequest request)
        {
            CreateAuthorCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateAuthorCommandRequest request)
        {
            UpdateAuthorCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAuthorCommandRequest request)
        {
            RemoveAuthorCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadAuthorImageCommandRequest request)
        {
            request.Files = Request.Form.Files;
            UploadAuthorImageCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetImages([FromRoute] GetAuthorImagesQueryRequest request)
        {
            List<GetAuthorImagesQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAuthorImageCommandRequest request, [FromQuery] string imageId)
        {
            request.ImageId = imageId;
            RemoveAuthorImageCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

    }
}
