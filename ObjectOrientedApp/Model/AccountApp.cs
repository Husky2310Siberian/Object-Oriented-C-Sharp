namespace ObjectOrientedApp;

public class AccountApp
{
    public int Id { get; set; }
    public string? Iban { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Ssn {get; set;}
    public decimal Balance {get; set;}

    public AccountApp() { }

    public AccountApp(int id, string? iban, string? firstname, string? lastname, string? ssn, decimal balance)
    {
        Id = id;
        Iban = iban;
        Firstname = firstname;
        Lastname = lastname;
        Ssn = ssn;
        Balance = balance;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Iban, Firstname, Lastname, Ssn, Balance);
    }

    public override string ToString()
    {
        return $"{{{Id}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance}}}";
    }
    
    
}