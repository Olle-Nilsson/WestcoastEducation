namespace WestcoastEducation;

public class Person
{
    public int PersonId { get; set; }
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public string ZipCode { get; set; } = "";

    public override string ToString()
    {
        return $"{FirstName} {LastName} {PhoneNumber} {SocialSecurityNumber} {Address} {ZipCode} {City}";
    }

}
