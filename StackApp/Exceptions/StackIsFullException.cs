namespace StackApp.Exceptions;

internal class StackIsFullException : Exception
{
    public StackIsFullException(string? message) : base(message)
    {
        
    }
}