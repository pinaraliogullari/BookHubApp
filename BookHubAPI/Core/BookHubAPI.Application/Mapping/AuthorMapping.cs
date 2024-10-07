using AutoMapper;
using BookHubAPI.Application.Features.Queires.Author.GetByIdAuthor;
using BookHubAPI.Domain.Entities;

namespace BookHubAPI.Application.Mapping
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, GetByIdAuthorQueryResponse>().ReverseMap();
        }
    }
}
