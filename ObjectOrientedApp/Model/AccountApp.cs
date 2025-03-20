using ObjectOrientedApp.Exceptions;

namespace ObjectOrientedApp;
/// <summary>
/// 
/// </summary>
public class AccountApp
{
    public int Id { get; set; }
    public string? Iban { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Ssn {get; set;}
    public decimal Balance {get; set;}

    public AccountApp() { }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="iban"></param>
    /// <param name="firstname"></param>
    /// <param name="lastname"></param>
    /// <param name="ssn"></param>
    /// <param name="balance"></param>
    public AccountApp(int id, string? iban, string? firstname, string? lastname, string? ssn, decimal balance)
    {
        Id = id;
        Iban = iban;
        Firstname = firstname;
        Lastname = lastname;
        Ssn = ssn;
        Balance = balance;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Iban, Firstname, Lastname, Ssn, Balance);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{{{Id}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance}}}";
    }

    /// <summary>
    /// Deposits an amount of money to the <see cref="AccountApp"/>>
    /// </summary>
    /// <param name="amount"></param>
    public void Deposit(decimal amount)
    {
        try
        {
            if(amount < 0) throw new NegativeAmountException("Error. Amount cannot be negative");
            Balance += amount;
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="ssn"></param>
    /// <exception cref="InvalidSsnException"></exception>
    /// <exception cref="NegativeAmountException"></exception>
    /// <exception cref="InsufficientBalanceException"></exception>
    public void Withdraw(decimal amount , string? ssn)
    {
        try
        {
            if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn!);
            if (Ssn != ssn) throw new InvalidSsnException(ssn);
            if (amount < 0) throw new NegativeAmountException("Error. Amount cannot be negative");
            if (amount > Balance)
                throw new InsufficientBalanceException("Error. Amount cannot be greater than balance");
            {
                Balance -= amount;
            }
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.StackTrace);
            throw;
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.StackTrace);
            throw;
        }
        catch (InvalidSsnException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public decimal GetBalance(decimal amount)
    {
        return Balance;
    }
}