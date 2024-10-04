using BookHubAPI.Application.Repositories;
using MediatR;

namespace BookHubAPI.Application.Features.Queires.GetAllAuthor
{
    public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQueryRequest, GetAllAuthorQueryResponse>
    {
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAllAuthorQueryHandler(IAuthorReadRepository authorReadRepository)
        {
            _authorReadRepository = authorReadRepository;
        }

        public async Task<GetAllAuthorQueryResponse> Handle(GetAllAuthorQueryRequest request, CancellationToken cancellationToken)
        {

            var totalCount = _authorReadRepository.GetAll(false).Count();
            var authors = _authorReadRepository.GetAll(false).Select(x => new
            {
                x.Id,
                x.CreatedDate,
                x.UpdatedDate,
                x.FirstName,
                x.LastName
            }).Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new()
            {
                Authors = authors,
                TotalCount = totalCount
            };
        }
    }
}
