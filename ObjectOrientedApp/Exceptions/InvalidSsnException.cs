namespace ObjectOrientedApp.Exceptions;

public class InvalidSsnException : Exception
{
    public InvalidSsnException(string ssn) : base("SSN" + ssn + "is not valid")
    {
        
    }
}