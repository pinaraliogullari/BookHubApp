namespace BookHubAPI.Application.Exceptions;

public class UserCreateFailedException : Exception
{
    public UserCreateFailedException() : base("An error occurred while creating the user")
    {
    }

    public UserCreateFailedException(string? message) : base(message)
    {
    }

    public UserCreateFailedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
