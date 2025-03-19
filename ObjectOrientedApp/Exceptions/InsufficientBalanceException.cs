namespace ObjectOrientedApp.Exceptions;

public class InsufficientBalanceException : Exception
{
    /*
     * This is a parameterized constructor that takes a message (error description).
     * The base(message) calls the base class (Exception) constructor, passing the error message.
     * This allows InsufficientBalanceException to behave like a normal exception but with a specific
     * name and purpose.
     */
    public InsufficientBalanceException(string message) : base(message)
    {
        
    }
}