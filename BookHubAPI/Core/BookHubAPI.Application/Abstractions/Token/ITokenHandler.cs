using BookHubAPI.Application.DTOs;

namespace BookHubAPI.Application.Abstractions.Token;

public interface ITokenHandler
{
    DTOs.Token CreateAccessToken(int minute);
}
