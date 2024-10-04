using BookHubAPI.Application.Abstractions.Storage;
using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Commands.AuthorImageFile.UploadAuthorImage;

public class UploadAuthorImageCommandHandler : IRequestHandler<UploadAuthorImageCommandRequest, UploadAuthorImageCommandResponse>
{
    private readonly IStorageService _storageService;
    private readonly IAuthorReadRepository _authorReadRepository;
    private readonly IAuthorImageFileWriteRepository _authorImageFileWriteRepository;

    public UploadAuthorImageCommandHandler(
        IStorageService storageService,
        IAuthorReadRepository authorReadRepository,
        IAuthorImageFileWriteRepository authorImageFileWriteRepository)
    {
        _storageService = storageService;
        _authorReadRepository = authorReadRepository;
        _authorImageFileWriteRepository = authorImageFileWriteRepository;
    }

    public async Task<UploadAuthorImageCommandResponse> Handle(UploadAuthorImageCommandRequest request, CancellationToken cancellationToken)
    {

        List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("images", request.Files);
        Domain.Entities.Author author = await _authorReadRepository.GetByIdAsync(request.Id);
        await _authorImageFileWriteRepository.AddRangeAsync(result.Select(x => new Domain.Entities.AuthorImageFile
        {
            FileName = x.fileName,
            Path = x.pathOrContainerName,
            Storage = _storageService.StorageName,
            Authors = new List<Domain.Entities.Author>() { author }
        }).ToList());
        await _authorImageFileWriteRepository.SaveChangesAsync();
        return new();
    }
}
