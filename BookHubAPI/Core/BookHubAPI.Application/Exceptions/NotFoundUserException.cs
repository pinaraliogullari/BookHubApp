namespace BookHubAPI.Application.Exceptions;

public class NotFoundUserException : Exception
{
    public NotFoundUserException() : base("Username or password is not correct")
    {

    }

    public NotFoundUserException(string? message) : base(message)
    {
    }

    public NotFoundUserException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
