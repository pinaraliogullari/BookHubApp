using BookHubAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookHubAPI.Application.Features.Queires.AuthorImageFile.GetAuthorImages
{
    public class GetAuthorImagesQueryHandler : IRequestHandler<GetAuthorImagesQueryRequest, GetAuthorImagesQueryResponse>
    {
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IConfiguration _configuration;

        public GetAuthorImagesQueryHandler(IAuthorReadRepository authorReadRepository, IConfiguration configuration)
        {
            _authorReadRepository = authorReadRepository;
            _configuration = configuration;
        }

        public async Task<List<GetAuthorImagesQueryResponse>> Handle(GetAuthorImagesQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Author? author = await _authorReadRepository.Table.Include(x => x.AuthorImageFiles).FirstOrDefaultAsync(x => x.Id == Guid.Parse(request.Id));
            return author?.AuthorImageFiles.Select(x => new GetAuthorImagesQueryResponse()
            {
                Id = x.Id,
                Path = $"{_configuration["BaseStorageUrl"]}/{x.Path}",
                FileName = x.FileName
            }).ToList();
        }
    }
}
