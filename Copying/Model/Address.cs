namespace Copying.Model;
/// <summary>
/// POCO class
/// </summary>
public class Address
{
    public string? StreetName { get; set; }
    public string? StreetNumber { get; set; }
    public string? ZipCode { get; set; }

    public Address() { }

    public Address(string? streetName, string? streetNumber, string? zipCode)
    {
        StreetName = streetName;
        StreetNumber = streetNumber;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{StreetName} {StreetNumber} {ZipCode}";
    }
}