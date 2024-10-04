using AutoMapper;
using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Queires.Author.GetByIdAuthor;

public class GetByIdAuthorQueryHandler : IRequestHandler<GetByIdAuthorQueryRequest, GetByIdAuthorQueryResponse>
{
    private readonly IAuthorReadRepository _authorReadRepository;
    private readonly IMapper _mapper;

    public GetByIdAuthorQueryHandler(IAuthorReadRepository authorReadRepository, IMapper mapper)
    {
        _authorReadRepository = authorReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdAuthorQueryResponse> Handle(GetByIdAuthorQueryRequest request, CancellationToken cancellationToken)
    {
        BookHubAPI.Domain.Entities.Author author = await _authorReadRepository.GetByIdAsync(request.Id, false);
        GetByIdAuthorQueryResponse response = _mapper.Map<GetByIdAuthorQueryResponse>(author);
        return response;

    }
}
